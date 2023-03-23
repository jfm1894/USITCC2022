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
        public AdminPanel()
        {
            InitializeComponent();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = Program.data;
            adminView.DataSource = bindingSource;
            adminView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.Controls.Add(bindingNavigator);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
           // bindingSource.MoveNext();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           // bindingSource.MoveNext();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
