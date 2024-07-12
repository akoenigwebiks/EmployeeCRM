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
                    TRY
                    {
                        UPDATE Passwords SET HasAccess = 0 WHERE EmployeeID = @EmployeeID;
                        INSERT INTO Passwords (EmployeeID, EmployeePassword, ExpiryDate, HasAccess)
                        VALUES (@EmployeeID, @NewPassword, DATEADD(DAY, 90, GETDATE()), 1);

                        COMMIT TRANSACTION;
                        SELECT 1;  -- Success
                    }
                    CATCH
                    {
                        ROLLBACK TRANSACTION;
                        SELECT 0;  -- Failure
                    }";

                SqlParameter[] parameters = {
                    new SqlParameter("@Tz", tz),
                    new SqlParameter("@NewPassword", newPassword)
                };

                int success = DBContext.ExecuteNonQuery(query, parameters);
                return success == 1;
            }
            catch
            {
                // Log the exception or handle it as needed
                return false;
            }
        }
    }
}
