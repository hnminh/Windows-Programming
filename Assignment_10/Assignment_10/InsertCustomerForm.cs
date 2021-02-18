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
    public partial class InsertCustomerForm : Form
    {
        string connectionString;
        private OleDbConnection oleDbConnection;
        private OleDbCommand insertCommand;

        public InsertCustomerForm(string connectionString)
        {
            this.connectionString = connectionString;

            InitializeComponent();
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(connectionString);

            insertCommand = oleDbConnection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO customers (customerId, customerName, flightId) " +
                "VALUES (@customerId, @customerName, @flightId);";
            insertCommand.Parameters.AddWithValue("@customerId", customerIdTextBox.Text);
            insertCommand.Parameters.AddWithValue("@customerName", customerNameTextBox.Text);
            insertCommand.Parameters.AddWithValue("@flightId", flightIdTextBox.Text);

            oleDbConnection.Open();
            int rows = insertCommand.ExecuteNonQuery();
            MessageBox.Show(rows + " row was added");
            oleDbConnection.Close();
        }
    }
}
