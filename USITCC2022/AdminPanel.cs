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
    public partial class AdminPanel : Form
    {
        private const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\programming\\USITCC2022\\USITCC2022\\GrandSlamInformation.accdb;Persist Security Info=True";

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            GrandSlamInformationDataSet grandSlamInformationDataSet = new GrandSlamInformationDataSet();
            GrandSlamInformationDataSetTableAdapters.GrandSlamInformationTableAdapter grandSlamInformationTableAdapter = new GrandSlamInformationDataSetTableAdapters.GrandSlamInformationTableAdapter();

            // Fill the DataTable with the data from the table
            grandSlamInformationTableAdapter.Fill(grandSlamInformationDataSet.GrandSlamInformation);

            // Create a new BindingSource and set its DataSource property to the DataTable
            bindingSource = new BindingSource();
            bindingSource.DataSource = grandSlamInformationDataSet.GrandSlamInformation;

            // Set the DataSource property of the DataGridView to the BindingSource
            adminView.DataSource = bindingSource;

            // Set the BindingNavigator control's BindingSource property to the BindingSource object
            bindingNavigator.BindingSource = bindingSource;

            // Move to the first record
            bindingSource.MoveFirst();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
 
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one

        }

        private void myBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one
        }

        private void myBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
