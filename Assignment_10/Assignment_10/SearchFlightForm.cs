using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10
{
    public partial class SearchFlightForm : Form
    {
        string connectionString;
        private OleDbConnection oleDbConnection;
        private OleDbCommand oleDbCommand;

        public SearchFlightForm(string connectionString)
        {
            this.connectionString = connectionString;

            InitializeComponent();
        }

        private void SearchFlightButton_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(connectionString);
            oleDbCommand = oleDbConnection.CreateCommand();
            oleDbConnection.Open();
            DataTable dataTable = new DataTable();

            oleDbCommand.CommandText = "SELECT * FROM flights WHERE flightId = @flightId";
            oleDbCommand.Parameters.AddWithValue("@flightId", flightIdTextBox.Text);
            dataTable.Load(oleDbCommand.ExecuteReader());
            oleDbCommand.CommandText = "SELECT * FROM customers WHERE flightId = @flightId";
            oleDbCommand.Parameters.AddWithValue("@flightId", flightIdTextBox.Text);
            dataTable.Load(oleDbCommand.ExecuteReader());
            flightsDataGridView.DataSource = dataTable;

            if (oleDbConnection != null)
            {
                oleDbConnection.Close();
            }
        }
    }
}
