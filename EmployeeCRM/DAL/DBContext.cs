using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;

namespace EmployeeCRM.DAL
{
    internal static class DBContext
    {
        private static readonly string _connectionString = "Data Source=AEK\\SQLEXPRESS;Initial catalog=company1;Integrated Security=True;";
        public static DataTable MakeQuery(string queryStr)
        {
            DataTable output = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Handle the exception as needed
                    }
                }
            }

            return output;
        }
    }
}
