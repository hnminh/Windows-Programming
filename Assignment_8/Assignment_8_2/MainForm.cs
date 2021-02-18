using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_8_2
{
    public partial class MainForm : Form
    {

        List<Flight> flights;
        SummaryForm summaryForm = null;

        public MainForm()
        {
            InitializeComponent();
            flights = new List<Flight>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dateBox.Text = "MM-DD-YYYY";
            this.timeBox.Text = "HH:MM";
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string flightId = this.flightIdBox.Text;
            string origin = this.originBox.Text;
            string destination = this.destinationBox.Text;
            DateTime date = new DateTime();
            DateTime.TryParse(this.dateBox.Text, out date);
            DateTime time = new DateTime();
            DateTime.TryParse(this.timeBox.Text, out time);

            flights.Add(new Flight(flightId, origin, destination, date, time));

            if (summaryForm == null || summaryForm.IsDisposed)
            {
                summaryForm = new SummaryForm();
                summaryForm.Show();
            }

            string summary = "";
            foreach (Flight flight in flights)
                summary += flight.ToString() + Environment.NewLine;

            summaryForm.AddText(summary);

        }
    }
}
