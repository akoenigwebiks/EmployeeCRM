using System;
using System.Data;

namespace EmployeeCRM.DAL
{
    internal static class SeedService
    {
        public static void EnsureDatabaseSetup()
        {
            EnsureTables();
            SeedData();
        }

        /// <summary>
        /// Ensures the necessary database tables (Employees, Passwords, and Shifts) exist.
        /// </summary>
        /// <remarks>
        /// This method checks for the existence of each table before attempting to create it.
        /// If a table does not exist, it is created with the specified schema.
        /// The Employees table includes columns for code, id, first_name, and last_name.
        /// The Passwords table includes columns for code, employee_code, password, expiry_date, and has_access,
        /// with a foreign key reference to the Employees table.
        /// The Shifts table includes columns for code, employee_code, entry_time, and exit_time,
        /// also with a foreign key reference to the Employees table.
        /// </remarks>
        private static void EnsureTables()
        {
            string sqlStatements = @"
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Employees' AND type = 'U')
                    CREATE TABLE [dbo].[Employees] (
                        [ID] INT IDENTITY (1, 1) NOT NULL,
                        [EmployeeNat] VARCHAR (10) NULL,
                        [EmployeeFirstName] VARCHAR (15) NULL,
                        [EmployeeLastName] VARCHAR (15) NULL,
                        PRIMARY KEY CLUSTERED ([ID] ASC)
                    );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Passwords' AND type = 'U')
                    CREATE TABLE [dbo].[Passwords] (
                        [ID] INT IDENTITY (1, 1) NOT NULL,
                        [EmployeeID] INT NULL,
                        [EmployeePassword] VARCHAR (12) NULL,
                        [ExpiryDate] DATE NULL,
                        [HasAccess] BIT NULL,
                        PRIMARY KEY CLUSTERED ([ID] ASC),
                        FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([ID])
                    );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Shifts' AND type = 'U')
                    CREATE TABLE [dbo].[Shifts] (
                        [ID] INT IDENTITY (1, 1) NOT NULL,
                        [EmployeeID] INT NULL,
                        [EntryTime] DATETIME NULL,
                        [ExitTime] DATETIME NULL,
                        PRIMARY KEY CLUSTERED ([ID] ASC),
                        FOREIGN KEY ([EmployeeID]) REFERENCES [dbo].[Employees] ([ID])
                    );";
            DBContext.ExecuteNonQuery(sqlStatements);
        }

        public static void SeedData()
        {
            if (IsTableEmpty("Employees") && IsTableEmpty("Passwords"))
            {
                string[] employeeIds = { "200024398", "200024367" };
                foreach (var id in employeeIds)
                {
                    // Insert into Employees
                    DBContext.ExecuteNonQuery($"INSERT INTO Employees (EmployeeNat, EmployeeFirstName, EmployeeLastName) VALUES ('{id}', 'John', 'Doe')");

                    // Retrieve the last inserted identity using ExecuteQuery and accessing the DataTable
                    DataTable result = DBContext.MakeQuery("SELECT MAX(ID) FROM Employees;");
                    int employeeCode = Convert.ToInt32(result.Rows[0][0]); // Convert the result to int

                    // Insert into Passwords
                    DBContext.ExecuteNonQuery($"INSERT INTO Passwords (EmployeeID, EmployeePassword, ExpiryDate, HasAccess) VALUES ({employeeCode}, '12345', '2099-12-31', 1)");

                    // Insert 4 shifts for each employee
                    for (int i = 1; i <= 4; i++)
                    {
                        // Assuming shifts are 8 hours long starting from 8:00 AM to 4:00 PM
                        // Adjust the dates as necessary
                        string entryTime = $"2023-06-0{i} 08:00:00";
                        string exitTime = $"2023-06-0{i} 16:00:00";

                        DBContext.ExecuteNonQuery($"INSERT INTO Shifts (EmployeeID, EntryTime, ExitTime) VALUES ({employeeCode}, '{entryTime}', '{exitTime}')");
                    }
                }
            }
        }

        private static bool IsTableEmpty(string tableName)
        {
            DataTable dt = DBContext.MakeQuery($"SELECT COUNT(*) FROM [{tableName}]");
            return (int)dt.Rows[0][0] == 0;
            //return (int)dt.Rows.Count == 0;
        }
    }
}
