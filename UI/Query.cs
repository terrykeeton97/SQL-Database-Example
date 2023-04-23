using SQL_Application.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQL_Application.UI
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            string query = queryTextBox.Text;
            string parameterInput = parametersTextBox.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a valid SQL query.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<SqlParameter> parameters = null;

            if (!string.IsNullOrWhiteSpace(parameterInput))
            {
                parameters = new List<SqlParameter>();
                string[] parameterValues = parameterInput.Split(',');

                for (int i = 0; i < parameterValues.Length; i++)
                {
                    SqlParameter parameter = new SqlParameter($"@Param{i + 1}", parameterValues[i].Trim());
                    parameters.Add(parameter);
                }
            }

            try
            {
                DataTable result = await SqlHandler.QueryAsync(query, parameters);
                //Do something with the new results after the query, reorganise the main form, or should we show a new form with the queryd information?
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Query successful");
        }

        private void queryTemplateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = queryTemplateComboBox.SelectedIndex;

            switch (index)
            {
                case 0:
                    queryTextBox.Text = "SELECT TOP 1000 * FROM Customers";
                    break;
                case 1:
                    queryTextBox.Text = "DELETE FROM Customers;";
                    break;
                default:
                    break;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Generate some fake info for the DGV and assign it to the SQL database
            Utils.InsertFakeData();
        }

        private async void Query_FormClosed(object sender, FormClosedEventArgs e)
        {
            await SqlHandler.RefreshConnectionAsync();
        }
    }
}
