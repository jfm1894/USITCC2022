namespace USITCC2022
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuperUserField = new System.Windows.Forms.TextBox();
            this.SuperUserLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(40, 224);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(298, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameField
            // 
            this.UserNameField.Location = new System.Drawing.Point(118, 71);
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(168, 20);
            this.UserNameField.TabIndex = 2;
            this.UserNameField.TextChanged += new System.EventHandler(this.UserNameField_TextChanged);
            // 
            // PasswordField
            // 
            this.PasswordField.Location = new System.Drawing.Point(118, 120);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(168, 20);
            this.PasswordField.TabIndex = 3;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(22, 71);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 120);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(86, 9);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(252, 26);
            this.MessageLabel.TabIndex = 6;
            this.MessageLabel.Text = "Welcome to Real Time Sports Management Agency\nPlease login to continue...";
            // 
            // SuperUserField
            // 
            this.SuperUserField.Location = new System.Drawing.Point(118, 168);
            this.SuperUserField.Name = "SuperUserField";
            this.SuperUserField.PasswordChar = '*';
            this.SuperUserField.Size = new System.Drawing.Size(168, 20);
            this.SuperUserField.TabIndex = 7;
            this.SuperUserField.Visible = false;
            // 
            // SuperUserLabel
            // 
            this.SuperUserLabel.AutoSize = true;
            this.SuperUserLabel.Location = new System.Drawing.Point(22, 171);
            this.SuperUserLabel.Name = "SuperUserLabel";
            this.SuperUserLabel.Size = new System.Drawing.Size(85, 13);
            this.SuperUserLabel.TabIndex = 8;
            this.SuperUserLabel.Text = "Admin Password";
            this.SuperUserLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 305);
            this.Controls.Add(this.SuperUserLabel);
            this.Controls.Add(this.SuperUserField);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginForm";
            this.Text = "Real Time Sports Management Agency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox SuperUserField;
        private System.Windows.Forms.Label SuperUserLabel;
    }
}

