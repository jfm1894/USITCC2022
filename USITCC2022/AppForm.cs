using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USITCC2022
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            dataView.DataSource = Program.data;
            dataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataView.RowHeadersVisible = false;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Show the main application form
            LoginForm mainForm = new LoginForm();
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            dataView.Sort(dataView.Columns["GrandSlamID"], ListSortDirection.Descending);
        }
    }
}
