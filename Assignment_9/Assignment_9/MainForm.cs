using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_9
{
    public partial class MainForm : Form
    {
        List<Flight> flights;
        List<Customer> customers;
        SummaryForm summaryForm = null;
        public MainForm()
        {
            InitializeComponent();
            flights = new List<Flight>();
            customers = new List<Customer>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            flightDateLabel.Text = "MM.DD.YYYY";
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            string flightId = this.flightIdTextBox.Text;
            string airline = this.airlineCompanyTextBox.Text;
            string origin = this.originTextBox.Text;
            string destination = this.destinationTextBox.Text;
            DateTime date = new DateTime();
            DateTime.TryParse(this.flightDateTextBox.Text, out date);

            flights.Add(new Flight(flightId, airline, origin, destination, date));
            MessageBox.Show("Flight added");
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            string customerId = this.customerIdTextBox.Text;
            string name = this.customerNameTextBox.Text;
            string flight = this.customerFlightTextBox.Text;

            customers.Add(new Customer(customerId, name, flight));
            MessageBox.Show("Customer added");
        }

        private void searchFlightButton_Click(object sender, EventArgs e)
        {
            string flightId = this.flightIdTextBox.Text;
            string result = "";

            foreach (Flight flight in flights)
            {
                if (flight.Id.Equals(flightId))
                {
                    result += flight.ToString() + Environment.NewLine;
                    result += "Customers: " + Environment.NewLine + Environment.NewLine;

                    foreach (Customer customer in customers)
                    {
                        if (customer.Flight.Equals(flightId)) {
                            result += customer.ToString() + Environment.NewLine;
                        }
                    }

                    result += "----------" + Environment.NewLine;
                }
            }

            if (summaryForm == null || summaryForm.IsDisposed)
            {
                summaryForm = new SummaryForm();
                summaryForm.Show();
            }

            summaryForm.AddText(result);

        }

        private void searchCustomerButton_Click(object sender, EventArgs e)
        {
            string customerId = customerIdTextBox.Text;
            string result = "";

            foreach (Customer customer in customers)
            {
                if (customer.Id.Equals(customerId))
                {
                    result += customer.ToString();

                    foreach (Flight flight in flights)
                    {
                        if (flight.Id.Equals(customer.Flight))
                        {
                            result += flight.ToString() + Environment.NewLine;
                        }
                    }

                    result += "----------" + Environment.NewLine;
                }
            }

            if (summaryForm == null || summaryForm.IsDisposed)
            {
                summaryForm = new SummaryForm();
                summaryForm.Show();
            }

            summaryForm.AddText(result);
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                //fileDialog.InitialDirectory = @"C:\Users\BOOTCAMP\Downloads\Assignment_9\";
                fileDialog.Filter = "All Files|*.json";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileHandler fileHandler = new FileHandler();

                    flights = fileHandler.ReadFlightsFromFileSerialization(fileDialog.FileName);
                }
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                //fileDialog.InitialDirectory = @"C:\Users\BOOTCAMP\Downloads\Assignment_9\";
                fileDialog.Filter = "All Files|*.json";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileHandler fileHandler = new FileHandler();

                    customers = fileHandler.ReadCustomersFromFileSerialization(fileDialog.FileName);
                }
            }
        }

        private void flightsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                //fileDialog.InitialDirectory = @"C:\Users\BOOTCAMP\Downloads\Assignment_9\";
                fileDialog.Filter = "All Files|*.json";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileHandler fileHandler = new FileHandler();

                    fileHandler.WriteFlightsToFileSerialization(flights, fileDialog.FileName);
                }
            }
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog fileDialog = new SaveFileDialog())
            {
                //fileDialog.InitialDirectory = @"C:\Users\BOOTCAMP\Downloads\Assignment_9\";
                fileDialog.Filter = "All Files|*.json";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileHandler fileHandler = new FileHandler();

                    fileHandler.WriteCustomersToFileSerialization(customers, fileDialog.FileName);
                }
            }
        }
    }
}
