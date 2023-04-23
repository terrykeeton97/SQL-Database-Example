using SQL_Application.Classes;
using SQL_Application.UI;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SQL_Application
{
    public partial class Main : Form
    {
        internal static DataTable dataTable = new DataTable();

        public Main()
        {
            InitializeComponent();

            //Setup the DGV
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.RowHeadersVisible = false;
        }

        private async void connectItem_Click(object sender, System.EventArgs e)
        {
            //Using async to avoid locking the UI on the current thread
            await SqlHandler.ConnectAsync();
            dataGrid.DataSource = dataTable;
        }

        private void disconnectItem_Click(object sender, System.EventArgs e)
        {
            SqlHandler.Disconnect();
            dataGrid.DataSource = null; 
            dataGrid.Rows.Clear(); //We must clear the data source and clear the table to avoid over-stacking the DGV with duplicate or incorrect information
        }

        private void connectionStatusTimer_Tick(object sender, System.EventArgs e)
        {
            if (Constants.isConnected)
            {
                connectionLabel.Text = "CONNECTED";
                connectionLabel.ForeColor = Color.DarkGreen;
                connectItem.Enabled = false;
                disconnectItem.Enabled = true;
                queryItem.Enabled = true;
                refreshItem.Enabled = true;
                return;
            }
            connectionLabel.Text = "DISCONNECTED";
            connectionLabel.ForeColor = Color.DarkRed;
            connectItem.Enabled = true;
            disconnectItem.Enabled = false;
            queryItem.Enabled = false;
            refreshItem.Enabled = false;

            //There are better ways to do this, however for readability I will keep it as is.
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Constants.isConnected)
                SqlHandler.Disconnect();
        }

        private void queryItem_Click(object sender, System.EventArgs e)
        {
            Query query = new Query();
            query.Show();
        }

        private async void refreshItem_Click(object sender, System.EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();
            await SqlHandler.RefreshConnectionAsync();
            dataGrid.DataSource = dataTable;
        }
    }
}
