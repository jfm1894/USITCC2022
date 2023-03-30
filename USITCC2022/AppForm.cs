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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace USITCC2022
{
    public partial class AppForm : Form
    {
        private const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\programming\\USITCC2022\\USITCC2022\\GrandSlamInformation.accdb;Persist Security Info=True";
        public static User loggedIn;
        public AppForm(User loggedUser)
        {
            InitializeComponent();
            loggedIn = loggedUser;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            if (loggedIn.IsAdmin == true)
            {
                string query = "SELECT * FROM GrandSlamInformation;";

                // Create a new DataTable object to hold the retrieved data
                DataTable dataTable = new DataTable();

                // Create a new OleDbDataAdapter object with the query and connection string
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                {
                    // Fill the DataTable with the query results
                    adapter.Fill(dataTable);
                }

                // Set the DataTable as the data source for the DataView
                dataView.DataSource = dataTable;
                dataView.Columns["Winning Player Earnings"].DefaultCellStyle.Format = "C";
                // add logic to check if user is an admin
                AdminButton.Visible = true;
            }
            else
            {
                if(loggedIn.Username == "rfederer")
                {
                    string query = "SELECT * FROM GrandSlamInformation WHERE [Winning Player Name] = 'Roger Federer'";

                    // Create a new DataTable object to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Create a new OleDbDataAdapter object with the query and connection string
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                    {
                        // Fill the DataTable with the query results
                        adapter.Fill(dataTable);
                    }

                    // Set the DataTable as the data source for the DataView
                    dataView.DataSource = dataTable;
                    dataView.Columns["Winning Player Earnings"].DefaultCellStyle.Format = "C";
                }
                else
                {
                    string query = "SELECT * FROM GrandSlamInformation WHERE [Winning Player Name] = 'Rafael Nadal'";

                    // Create a new DataTable object to hold the retrieved data
                    DataTable dataTable = new DataTable();

                    // Create a new OleDbDataAdapter object with the query and connection string
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, connectionString))
                    {
                        // Fill the DataTable with the query results
                        adapter.Fill(dataTable);
                    }

                    // Set the DataTable as the data source for the DataView
                    dataView.DataSource = dataTable;
                    dataView.Columns["Winning Player Earnings"].DefaultCellStyle.Format = "C";
                }
            }
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main application form
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
        }


        private void SortButton_Click(object sender, EventArgs e)
        {
            dataView.Sort(dataView.Columns["Grand Slam ID"], ListSortDirection.Descending);
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            this.Hide();
            DialogResult result = adminPanel.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Application.Exit();
        }

        private void SortEarnings_Click(object sender, EventArgs e)
        {
            // Assuming the DataGridView is named "dataGridView1"
            DataTable dataTable = (DataTable)dataView.DataSource;
            decimal minValue = decimal.Parse(EarningsBox.Text);
            // Filter the rows of the DataTable
            dataTable.DefaultView.RowFilter = $"[Winning Player Earnings] >= {minValue}";

            // Update the DataGridView to display the filtered rows
            dataView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataView.DataSource;
            dataTable.DefaultView.RowFilter = "";
            dataView.Refresh();             
        }

        private void SortSlam_Click(object sender, EventArgs e)
        {
            DataTable dataTable = (DataTable)dataView.DataSource;

            // Get the user input from a text box (assuming the text box is named "SearchTextBox")
            string searchTerm = SlamBox.Text;

            // Filter the rows of the DataTable to find partial matches
            dataTable.DefaultView.RowFilter = $"[Grand Slam Name] LIKE '%{searchTerm}%'";

            // Update the DataGridView to display the filtered rows
            dataView.Refresh();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
