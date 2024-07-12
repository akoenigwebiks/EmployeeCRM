using EmployeeCRM.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeCRM.Services
{
    public enum AuthResult
    {
        Success,
        InvalidCredentials,
        NoAccess,
        PasswordExpired,
        Error
    }
    internal static class AuthService
    {
        private static string? _Tz;
        // public static string Tz { get { return _Tz; } }
        public static string Tz => _Tz;
        public static AuthResult Login(string tz, string password)
        {
            try
            {
                // Ensure the password is treated as a string in the SQL query
                string query = @"SELECT Employees.EmployeeNat, 
                                        Passwords.EmployeePassword, 
                                        Passwords.HasAccess, 
                                        Passwords.ExpiryDate
                                     FROM Employees
                                     JOIN Passwords ON Employees.ID = Passwords.EmployeeID
                                     WHERE Employees.EmployeeNat = @Tz 
                                     AND Passwords.EmployeePassword = @Password;";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Tz", tz),
                    new SqlParameter("@Password", password)
                };

                DataTable result = DBContext.MakeQuery(query, parameters);
                DataRow user = result.Rows[0];
                bool hasAccess = (bool)user["HasAccess"];
                DateTime expiryDate = (DateTime)user["ExpiryDate"];
                _Tz = tz;

                return result switch
                {
                    _ when result.Rows.Count == 0 || !hasAccess => AuthResult.InvalidCredentials,
                    _ when expiryDate < DateTime.Now => AuthResult.PasswordExpired,
                    _ => AuthResult.Success
                };
            }
            catch (Exception)
            {
                return AuthResult.Error;
            }
        }

        public static bool ChangePassword(string tz, string oldPassword, string newPassword)
        {
            try
            {
                string query = @"
                    DECLARE @EmployeeID INT;
                    SELECT @EmployeeID = ID FROM Employees WHERE EmployeeNat = @Tz;
                    
                    IF @EmployeeID IS NULL
                        THROW 50001, 'No employee found with the given national ID.', 1;

                    BEGIN TRANSACTION;
                    BEGIN TRY
                        UPDATE Passwords SET HasAccess = 0 WHERE EmployeeID = @EmployeeID;
                        INSERT INTO Passwords (EmployeeID, EmployeePassword, ExpiryDate, HasAccess)
                        VALUES (@EmployeeID, @NewPassword, DATEADD(DAY, 90, GETDATE()), 1);

                        COMMIT TRANSACTION;
                        SELECT 1;  -- Success
                    END TRY
                    BEGIN CATCH
                        ROLLBACK TRANSACTION;
                        SELECT 0;  -- Failure
                    END CATCH;";

                SqlParameter[] parameters = {
                    new SqlParameter("@Tz", tz),
                    new SqlParameter("@NewPassword", newPassword)
                };

                int success = DBContext.ExecuteNonQuery(query, parameters);
                return success > 0;
            }
            catch
            {
                // Log the exception or handle it as needed
                return false;
            }
        }

        public static DataTable GetShiftRecords()
        {
            // get from shifts table the most recent shift record for the current employee
            string query = @"
                            DECLARE @EmployeeID INT;
                            SELECT @EmployeeID = ID FROM Employees WHERE EmployeeNat = @Tz;
        
                            IF @EmployeeID IS NULL
                                THROW 50001, 'No employee found with the given national ID.', 1;

                            SELECT TOP 1 EntryTime, ExitTime
                            FROM Shifts
                            WHERE EmployeeID = @EmployeeID
                            ORDER BY EntryTime DESC;";


            SqlParameter[] parameters = { new SqlParameter("@Tz", _Tz) };
            return DBContext.MakeQuery(query, parameters);
        }

        public static bool ClockIn()
        {
            string query = @"
                BEGIN TRANSACTION;
                BEGIN TRY
                    DECLARE @EmployeeID INT;
                    SELECT @EmployeeID = ID FROM Employees WHERE EmployeeNat = @Tz;

                    IF @EmployeeID IS NULL
                        THROW 50001, 'No employee found with the given national ID.', 1;

                    -- Check if there is an ongoing shift that has not been clocked out
                    IF EXISTS (SELECT 1 FROM Shifts WHERE EmployeeID = @EmployeeID AND ExitTime IS NULL)
                        THROW 50002, 'Employee has not clocked out from the last shift.', 1;

                    -- Insert a new shift record with the current date and time as the entry time
                    INSERT INTO Shifts (EmployeeID, EntryTime)
                    VALUES (@EmployeeID, GETDATE());

                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    -- Re-throw the caught exception to handle it outside or log it
                    THROW;
                END CATCH;";

            SqlParameter[] parameters = { new SqlParameter("@Tz", _Tz) };
            try
            {
                int success = DBContext.ExecuteNonQuery(query, parameters);
                return success > 0;
            }
            catch (Exception ex)
            {
                // Log the error or handle it accordingly
                Console.WriteLine("Error during clock in: " + ex.Message);
                return false;
            }
        }

        public static bool ClockOut()
        {
            string query = @"
                                BEGIN TRANSACTION;
                                BEGIN TRY
                                    DECLARE @EmployeeID INT;
                                    SELECT @EmployeeID = ID FROM Employees WHERE EmployeeNat = @Tz;
                    
                                    IF @EmployeeID IS NULL
                                        THROW 50001, 'No employee found with the given national ID.', 1;

                                    -- Find the most recent Shift entry that is still open (ExitTime IS NULL)
                                    DECLARE @ShiftID INT;
                                    SELECT TOP 1 @ShiftID = ID FROM Shifts
                                    WHERE EmployeeID = @EmployeeID AND ExitTime IS NULL
                                    ORDER BY EntryTime DESC;

                                    IF @ShiftID IS NULL
                                        THROW 50002, 'No open shift found to clock out.', 1;

                                    -- Update the ExitTime to the current time for the found Shift
                                    UPDATE Shifts
                                    SET ExitTime = GETDATE()
                                    WHERE ID = @ShiftID;

                                    COMMIT TRANSACTION;
                                END TRY
                                BEGIN CATCH
                                    ROLLBACK TRANSACTION;
                                    THROW;
                                END CATCH";
            SqlParameter[] parameters = { new SqlParameter("@Tz", _Tz) };
            int success = DBContext.ExecuteNonQuery(query, parameters);
            return success > 0;
        }
    }
}

