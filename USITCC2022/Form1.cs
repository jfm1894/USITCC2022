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
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace USITCC2022
{
   
    public partial class LoginForm : Form
    {
        public static int AttemptCount = 3;
        private const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\programming\\USITCC2022\\USITCC2022\\GrandSlamInformation.accdb;Persist Security Info=True";

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
            if(UserNameField.Text != "admin")
            {
                if(AuthenticateUser(UserNameField.Text,PasswordField.Text) == true)
                {
                    User user = new User(UserNameField.Text,PasswordField.Text);
                    AppForm app = new AppForm(user);
                    this.Hide();
                    DialogResult result = app.ShowDialog();
                    if(result == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                else
                {
                    failedAttempt();
                }
            }
            else
            {
                if(AuthenticateAdmin(UserNameField.Text,PasswordField.Text,SuperUserField.Text) == true)
                {
                    SuperUser superUser = new SuperUser(UserNameField.Text,PasswordField.Text,SuperUserField.Text);
                    AppForm app = new AppForm(superUser);
                    this.Hide();
                    DialogResult result = app.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.Show();
                    }
                }
                else
                {
                    failedAttempt();
                }
            }

        }

        private void failedAttempt()
        {
            AttemptCount--;
            MessageBox.Show("Incorrect username or password. Please try again, Login attempts remaining: "+ AttemptCount, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if(AttemptCount == 0)
            {
                Application.Exit();
            }
        }


        private bool AuthenticateUser(string un, string pass)
        {
            // Construct a SELECT query to retrieve the user's record from the database
            string query = "SELECT * FROM Credentials WHERE username = @username AND password = @password;";

            // Create a new OleDbConnection object and open it
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Create a new OleDbCommand object with the query and connection
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Add parameters to the command for the username and password
                    command.Parameters.AddWithValue("@username", un);
                    command.Parameters.AddWithValue("@password", pass);

                    // Execute the command and get a OleDbDataReader object
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        // If the reader has any rows, the user is authenticated
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }

        private bool AuthenticateAdmin(string un, string pass, string apass) 
        {
            // Construct a SELECT query to retrieve the user's record from the database
            string query = "SELECT * FROM AdminCredentials WHERE username = @username AND password = @password AND adminpassword = @adminPassword;";

            // Create a new OleDbConnection object and open it
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Create a new OleDbCommand object with the query and connection
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Add parameters to the command for the username, password, and admin password
                    command.Parameters.AddWithValue("@username", un);
                    command.Parameters.AddWithValue("@password", pass);
                    command.Parameters.AddWithValue("@adminPassword", apass);

                    // Execute the command and get a OleDbDataReader object
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        // If the reader has any rows, the user is authenticated
                        if (reader.HasRows)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
        }


    }
}

