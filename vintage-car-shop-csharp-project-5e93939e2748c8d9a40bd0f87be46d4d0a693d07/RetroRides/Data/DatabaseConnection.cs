using System;
using System.Data;
using System.Data.SqlClient;

namespace RetroRides.Data
{
    public class DatabaseConnection
    {
        // Connection string with a relative path
        private readonly string connectionString;

        public DatabaseConnection()
        {

            // Construct the connection string using the dynamic path
            connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=path\to\RetroRides.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        }

        // Method to get a new open connection
        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();  // Open the connection
            return conn;
        }

        // Method to execute a scalar query (returns a single value)
        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the command if any
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    // Execute the scalar query
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Method to execute a non-query (e.g., INSERT, UPDATE, DELETE)
        // Executes a non-query command (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Add each parameter to the command
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Executes a query that returns a DataTable
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Add each parameter to the command
                        foreach (var param in parameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }


        // Method to check if a record exists (returns true if found)
        public bool RecordExists(string query, SqlParameter[] parameters)
        {
            object result = ExecuteScalar(query, parameters);
            if (result != null && Convert.ToInt32(result) > 0)
            {
                return true;
            }
            return false;
        }

    }
}
