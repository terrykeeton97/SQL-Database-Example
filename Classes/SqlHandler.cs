using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Application.Classes
{
    internal class SqlHandler
    {
        internal static SqlConnection sqlConnection = new SqlConnection(Constants.connectionString);

        internal static async Task<bool> ConnectAsync()
        {
            try
            {
                await sqlConnection.OpenAsync();

                if (sqlConnection.State == ConnectionState.Open)
                {
                    Constants.isConnected = true;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.Customers", sqlConnection);
                    Main.dataTable.Clear();
                    dataAdapter.Fill(Main.dataTable);
                }
            }
            catch (Exception ex)
            {
                //Proper error logging system, using messagebox for now
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        internal static bool Disconnect()
        {
            try
            {
                Main.dataTable.Clear();
                sqlConnection.Close();

                if (sqlConnection.State == ConnectionState.Closed)
                    Constants.isConnected = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        internal static async Task<bool> RefreshConnectionAsync()
        {
            try
            {
                Disconnect();              
                await ConnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Executes an asynchronous SQL query with the specified parameters and returns the result as a DataTable.
        /// </summary>
        /// <param name="query">A SQL query string to be executed.</param>
        /// <param name="parameters">A list of SqlParameter objects representing the parameters to be used in the query.</param>
        /// <returns>A DataTable containing the results of the executed query.</returns>
        /// <exception cref="System.Exception">Thrown when an error occurs during the execution of the query.</exception>
        internal static async Task<DataTable> QueryAsync(string query, List<SqlParameter> parameters)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(Constants.connectionString))
                {
                    await connection.OpenAsync();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            foreach (SqlParameter parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }

                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}