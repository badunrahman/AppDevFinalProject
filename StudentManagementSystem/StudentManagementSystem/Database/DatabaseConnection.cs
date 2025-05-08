using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace StudentManagementSystem.Database
{
    public class DatabaseConnection
    {
        // Get connection string from App.config
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementDB"].ConnectionString;

        /// <summary>
        /// Creates and returns a new SqlConnection object
        /// </summary>
        /// <returns>An open SqlConnection</returns>
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Executes a non-query SQL command
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a single value
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>The first column of the first row in the result set</returns>
        public static object ExecuteScalar(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a DataTable
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>A DataTable containing the query results</returns>
        public static DataTable ExecuteQuery(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a SqlDataReader
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>A SqlDataReader containing the query results</returns>
        public static SqlDataReader ExecuteReader(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(commandText, connection);

            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }

            // Note: CommandBehavior.CloseConnection will close the connection when the reader is closed
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Begins a SQL transaction
        /// </summary>
        /// <returns>A SqlTransaction object</returns>
        public static SqlTransaction BeginTransaction()
        {
            SqlConnection connection = GetConnection();
            return connection.BeginTransaction();
        }

        /// <summary>
        /// Executes a SQL command as part of a transaction
        /// </summary>
        /// <param name="transaction">The transaction to use</param>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteTransactionNonQuery(SqlTransaction transaction, string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand command = new SqlCommand(commandText, transaction.Connection, transaction))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }

                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Tests the database connection
        /// </summary>
        /// <returns>True if the connection is successful</returns>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    return connection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}