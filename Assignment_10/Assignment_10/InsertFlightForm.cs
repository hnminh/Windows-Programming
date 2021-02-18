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
    public partial class InsertFlightForm : Form
    {
        string connectionString;
        private OleDbConnection oleDbConnection;
        private OleDbCommand insertCommand;

        public InsertFlightForm(string connectionString)
        {
            this.connectionString = connectionString;

            InitializeComponent();
        }

        private void AddFlightButton_Click(object sender, EventArgs e)
        {
            oleDbConnection = new OleDbConnection(connectionString);

            insertCommand = oleDbConnection.CreateCommand();
            insertCommand.CommandText = "INSERT INTO flights (flightId, airlineCompany, origin, destination, flightDate) " +
                "VALUES (@flightId, @airlineCompany, @origin, @destination, @flightDate);";
            insertCommand.Parameters.AddWithValue("@flightId", flightIdTextBox.Text);
            insertCommand.Parameters.AddWithValue("@airlineCompany", airlineCompanyTextBox.Text);
            insertCommand.Parameters.AddWithValue("@origin", originTextBox.Text);
            insertCommand.Parameters.AddWithValue("@destination", destinationTextBox.Text);
            insertCommand.Parameters.AddWithValue("@flightDate", dateTextBox.Text);

            oleDbConnection.Open();
            int rows = insertCommand.ExecuteNonQuery();
            MessageBox.Show(rows + " row was added");
            oleDbConnection.Close();
        }
    }
}
