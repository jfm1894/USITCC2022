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
    public partial class AdminPanel : Form
    {
        private BindingSource bindingSource;

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            DataView dataView = new DataView();
            dataView.RowFilter = "ID = 1";
            bindingSource = new BindingSource();
            bindingSource.DataSource = Program.data;
            bindingSource.AllowNew = true;
            adminView.DataSource = bindingSource;
            adminView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Add the BindingNavigator control to the form
            this.Controls.Add(bindingNavigator);
            // Set the BindingNavigator control's BindingSource property
            bindingNavigator.BindingSource = bindingSource;
            // Dock the BindingNavigator control to the top of the form
            bindingNavigator.Dock = DockStyle.Top;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one
            bindingSource.MovePrevious();
        }

        private void myBindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one
            bindingSource.AddNew();
        }

        private void myBindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            // Use the existing BindingSource object instead of creating a new one
            bindingSource.RemoveCurrent();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
