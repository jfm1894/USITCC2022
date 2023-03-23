using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace USITCC2022
{
   
    public partial class LoginForm : Form
    {
        public static int AttemptCount = 0;

        public LoginForm()
        {
            InitializeComponent();
            Console.WriteLine("Main form loaded");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void UserNameField_TextChanged(object sender, EventArgs e)
        {
            if(UserNameField.Text.Equals("admin"))
            {
                SuperUserLabel.Visible = true;
                SuperUserField.Visible = true;
            }
            else
            {
                SuperUserLabel.Visible = false;
                SuperUserField.Visible = false;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameField.Text == Program.admins[0].Username && PasswordField.Text == Program.admins[0].Password && SuperUserField.Text == Program.admins[0].AdminPassword)
            {
                // Hide the login form
                this.Hide();
                // Show the main application form
                AppForm mainForm = new AppForm(Program.admins[0]);
                mainForm.Show();
            }
            else
            {
                bool userFound = false;
                int userIndex = 0;
                for (int i = 0; i < Program.users.Count(); i++)
                {
                    if (Program.users[i].Username == UserNameField.Text)
                    {
                        userFound = true;
                        userIndex = i; break;
                    }
                }
                if (userFound)
                {
                    if (Program.users[userIndex].Password == PasswordField.Text)
                    {
                        // Hide the login form
                        this.Hide();
                        // Show the main application form
                        AppForm mainForm = new AppForm(Program.users[userIndex]);
                        mainForm.Show();
                    }
                }
                else
                {
                    if(AttemptCount == 2)
                    {
                        Application.Exit();
                    }
                    MessageBox.Show("Incorrect username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AttemptCount++;
                }
            }

        }
    }
}
