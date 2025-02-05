﻿using System;
using System.Data.SqlClient;
using System.Data;

namespace EmployeeCRM.DAL
{
    internal static class DBContext
    {
        private static readonly string _DBName = "CompanyStaging";
        private static readonly string _connectionString = $"Data Source=AEK;Initial catalog={_DBName};Integrated Security=True;";

        public static DataTable MakeQuery(string queryStr, SqlParameter[] parameters)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
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
                        // Further error handling
                    }
                }
            }
            return output;
        }

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

        public static int ExecuteNonQuery(string queryStr, SqlParameter[] parameters)
        {
            int affectedRows = 0;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        affectedRows = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Consider more detailed exception handling or logging
                    }
                }
            }
            return affectedRows;
        }

        public static int ExecuteNonQuery(string queryStr)
        {
            int affectedRows = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(queryStr, conn))
                {
                    try
                    {
                        conn.Open();
                        affectedRows = cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine("An error occurred: " + ex.Message);
                        // Handle the exception as needed
                    }
                }
            }

            return affectedRows;
        }
    }
}
