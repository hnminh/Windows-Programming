using ADOX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_10
{
    public partial class MainForm : Form
    {
        private int insertFlightFormCounter;
        private int insertCustomerFormCounter;
        private int searchCustomerFormCounter;
        private int searchFlightFormCounter;

        OleDbConnection oleDBConnection;
        OleDbCommand oleDbCommand;
        string connectionString;
        string errorFeedback;
        string dataSource = @"C:\Users\BOOTCAMP\Downloads\Assignment_10\Assignment_10\app.mdb";

        private void Init()
        {
            ADOX.Catalog cat = new ADOX.Catalog();

            ADOX.Table customersTable = new ADOX.Table();
            customersTable.Name = "customers";
            customersTable.Columns.Append("customerId", ADOX.DataTypeEnum.adVarWChar, 255);
            customersTable.Columns.Append("customerName", ADOX.DataTypeEnum.adVarWChar, 255);
            customersTable.Columns.Append("flightId", ADOX.DataTypeEnum.adVarWChar, 255);

            ADOX.Table flightsTable = new ADOX.Table();
            flightsTable.Name = "flights";
            flightsTable.Columns.Append("flightId", ADOX.DataTypeEnum.adVarWChar, 255);
            flightsTable.Columns.Append("airlineCompany", ADOX.DataTypeEnum.adVarWChar, 255);
            flightsTable.Columns.Append("origin", ADOX.DataTypeEnum.adVarWChar, 255);
            flightsTable.Columns.Append("destination", ADOX.DataTypeEnum.adVarWChar, 255);
            flightsTable.Columns.Append("flightDate", ADOX.DataTypeEnum.adVarWChar, 255);

            cat.Create(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource);
            cat.Tables.Append(customersTable);
            cat.Tables.Append(flightsTable);
        }

        public MainForm()
        {
            if (!File.Exists(dataSource)) Init();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mainMenuStrip.MdiWindowListItem = windowToolStripMenuItem;
        }

        private void InsertFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

            insertFlightFormCounter++;
            InsertFlightForm insertFlightChildForm = new InsertFlightForm(connectionString);
            insertFlightChildForm.Text += " " + insertFlightFormCounter;
            insertFlightChildForm.MdiParent = this;
            insertFlightChildForm.Show();
        }

        private void InsertCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

            insertCustomerFormCounter++;
            InsertCustomerForm insertCustomerChildForm = new InsertCustomerForm(connectionString);
            insertCustomerChildForm.Text += " " + insertCustomerFormCounter;
            insertCustomerChildForm.MdiParent = this;
            insertCustomerChildForm.Show();
        }

        private void SearchFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

            searchFlightFormCounter++;
            SearchFlightForm searchFlightChildForm = new SearchFlightForm(connectionString);
            searchFlightChildForm.Text += " " + searchFlightFormCounter;
            searchFlightChildForm.MdiParent = this;
            searchFlightChildForm.Show();
        }

        private void SearchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource;

            searchCustomerFormCounter++;
            SearchCustomerForm searchCustomerChildForm = new SearchCustomerForm(connectionString);
            searchCustomerChildForm.Text += " " + searchCustomerFormCounter;
            searchCustomerChildForm.MdiParent = this;
            searchCustomerChildForm.Show();
        }
    }
}
