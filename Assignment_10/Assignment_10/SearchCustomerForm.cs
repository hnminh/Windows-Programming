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
    public partial class SearchCustomerForm : Form
    {
        string connectionString;
        private OleDbConnection oleDbConnection;
        private OleDbCommand oleDbCommand;

        public SearchCustomerForm(string connectionString)
        {
            this.connectionString = connectionString;

            InitializeComponent();
        }

        private void SearchCustomerButton_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(connectionString);
            oleDbCommand = oleDbConnection.CreateCommand();
            oleDbCommand.CommandText = "SELECT * FROM customers, flights WHERE customerId = @customerId AND customers.flightId = flights.flightId";
            oleDbCommand.Parameters.AddWithValue("@customerId", customerIdTextBox.Text);
            oleDbConnection.Open();

            DataTable dataTable = new DataTable();
            dataTable.Load(oleDbCommand.ExecuteReader());
            customersDataGridView.DataSource = dataTable;
            if (oleDbConnection != null)
            {
                oleDbConnection.Close();
            }
        }
    }
}
