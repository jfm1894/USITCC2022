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

namespace USITCC2022
{
    public partial class AppForm : Form
    {
        public static User loggedIn;
        public AppForm(User loggedUser)
        {
            InitializeComponent();
            loggedIn = loggedUser;
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'grandSlamInformationDataSet.GrandSlamInformation' table. You can move, or remove it, as needed.
            this.grandSlamInformationTableAdapter.Fill(this.grandSlamInformationDataSet.GrandSlamInformation);
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataView.RowHeadersVisible = false;
            // add logic to check if user is an admin
            if (loggedIn.IsAdmin == true)
            {
                AdminButton.Visible = true;
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
            if(result == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void AppForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Application.Exit();
        }
    }
}
