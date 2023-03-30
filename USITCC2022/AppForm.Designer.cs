namespace USITCC2022
{
    partial class AppForm
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
            this.components = new System.ComponentModel.Container();
            this.SortEarnings = new System.Windows.Forms.Button();
            this.SortSlam = new System.Windows.Forms.Button();
            this.EarningsBox = new System.Windows.Forms.TextBox();
            this.SlamBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.grandSlamInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grandSlamInformationDataSet = new USITCC2022.GrandSlamInformationDataSet();
            this.AdminButton = new System.Windows.Forms.Button();
            this.grandSlamInformationTableAdapter = new USITCC2022.GrandSlamInformationDataSetTableAdapters.GrandSlamInformationTableAdapter();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SortEarnings
            // 
            this.SortEarnings.Location = new System.Drawing.Point(32, 402);
            this.SortEarnings.Name = "SortEarnings";
            this.SortEarnings.Size = new System.Drawing.Size(75, 37);
            this.SortEarnings.TabIndex = 2;
            this.SortEarnings.Text = "Sort by earnings";
            this.SortEarnings.UseVisualStyleBackColor = true;
            this.SortEarnings.Click += new System.EventHandler(this.SortEarnings_Click);
            // 
            // SortSlam
            // 
            this.SortSlam.Location = new System.Drawing.Point(257, 403);
            this.SortSlam.Name = "SortSlam";
            this.SortSlam.Size = new System.Drawing.Size(75, 36);
            this.SortSlam.TabIndex = 3;
            this.SortSlam.Text = "Sort by grand slam";
            this.SortSlam.UseVisualStyleBackColor = true;
            this.SortSlam.Click += new System.EventHandler(this.SortSlam_Click);
            // 
            // EarningsBox
            // 
            this.EarningsBox.Location = new System.Drawing.Point(132, 409);
            this.EarningsBox.Name = "EarningsBox";
            this.EarningsBox.Size = new System.Drawing.Size(100, 20);
            this.EarningsBox.TabIndex = 5;
            // 
            // SlamBox
            // 
            this.SlamBox.Location = new System.Drawing.Point(352, 410);
            this.SlamBox.Name = "SlamBox";
            this.SlamBox.Size = new System.Drawing.Size(100, 20);
            this.SlamBox.TabIndex = 6;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(477, 409);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 12);
            this.dataView.Name = "dataView";
            this.dataView.ShowEditingIcon = false;
            this.dataView.Size = new System.Drawing.Size(544, 288);
            this.dataView.TabIndex = 8;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            // 
            // grandSlamInformationBindingSource
            // 
            this.grandSlamInformationBindingSource.DataMember = "GrandSlamInformation";
            this.grandSlamInformationBindingSource.DataSource = this.grandSlamInformationDataSet;
            // 
            // grandSlamInformationDataSet
            // 
            this.grandSlamInformationDataSet.DataSetName = "GrandSlamInformationDataSet";
            this.grandSlamInformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(477, 329);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(75, 23);
            this.AdminButton.TabIndex = 9;
            this.AdminButton.Text = "Admin Panel";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Visible = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // grandSlamInformationTableAdapter
            // 
            this.grandSlamInformationTableAdapter.ClearBeforeFill = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(32, 329);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SlamBox);
            this.Controls.Add(this.EarningsBox);
            this.Controls.Add(this.SortSlam);
            this.Controls.Add(this.SortEarnings);
            this.Name = "AppForm";
            this.Text = "AppForm";
            this.Load += new System.EventHandler(this.AppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SortEarnings;
        private System.Windows.Forms.Button SortSlam;
        private System.Windows.Forms.TextBox EarningsBox;
        private System.Windows.Forms.TextBox SlamBox;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button AdminButton;
        private GrandSlamInformationDataSet grandSlamInformationDataSet;
        private System.Windows.Forms.BindingSource grandSlamInformationBindingSource;
        private GrandSlamInformationDataSetTableAdapters.GrandSlamInformationTableAdapter grandSlamInformationTableAdapter;
        private System.Windows.Forms.Button refreshButton;
    }
}