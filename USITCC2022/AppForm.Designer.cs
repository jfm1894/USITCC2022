﻿namespace USITCC2022
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
            this.SortButton = new System.Windows.Forms.Button();
            this.SortEarnings = new System.Windows.Forms.Button();
            this.SortSlam = new System.Windows.Forms.Button();
            this.EarningsBox = new System.Windows.Forms.TextBox();
            this.SlamBox = new System.Windows.Forms.TextBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.grandSlamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winningPlayerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winningPlayerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winningPlayerEarningsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandSlamIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grandSlamInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grandSlamInformationDataSet = new USITCC2022.GrandSlamInformationDataSet();
            this.AdminButton = new System.Windows.Forms.Button();
            this.grandSlamInformationTableAdapter = new USITCC2022.GrandSlamInformationDataSetTableAdapters.GrandSlamInformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandSlamInformationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(12, 401);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 37);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sort by year";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // SortEarnings
            // 
            this.SortEarnings.Location = new System.Drawing.Point(114, 401);
            this.SortEarnings.Name = "SortEarnings";
            this.SortEarnings.Size = new System.Drawing.Size(75, 37);
            this.SortEarnings.TabIndex = 2;
            this.SortEarnings.Text = "Sort by earnings";
            this.SortEarnings.UseVisualStyleBackColor = true;
            // 
            // SortSlam
            // 
            this.SortSlam.Location = new System.Drawing.Point(311, 402);
            this.SortSlam.Name = "SortSlam";
            this.SortSlam.Size = new System.Drawing.Size(75, 36);
            this.SortSlam.TabIndex = 3;
            this.SortSlam.Text = "Sort by grand slam";
            this.SortSlam.UseVisualStyleBackColor = true;
            // 
            // EarningsBox
            // 
            this.EarningsBox.Location = new System.Drawing.Point(195, 410);
            this.EarningsBox.Name = "EarningsBox";
            this.EarningsBox.Size = new System.Drawing.Size(100, 20);
            this.EarningsBox.TabIndex = 5;
            // 
            // SlamBox
            // 
            this.SlamBox.Location = new System.Drawing.Point(392, 411);
            this.SlamBox.Name = "SlamBox";
            this.SlamBox.Size = new System.Drawing.Size(100, 20);
            this.SlamBox.TabIndex = 6;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(522, 407);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // dataView
            // 
            this.dataView.AutoGenerateColumns = false;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grandSlamNameDataGridViewTextBoxColumn,
            this.winningPlayerIDDataGridViewTextBoxColumn,
            this.winningPlayerNameDataGridViewTextBoxColumn,
            this.winningPlayerEarningsDataGridViewTextBoxColumn,
            this.grandSlamIDDataGridViewTextBoxColumn});
            this.dataView.DataSource = this.grandSlamInformationBindingSource;
            this.dataView.Location = new System.Drawing.Point(12, 12);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(585, 288);
            this.dataView.TabIndex = 8;
            // 
            // grandSlamNameDataGridViewTextBoxColumn
            // 
            this.grandSlamNameDataGridViewTextBoxColumn.DataPropertyName = "Grand Slam Name";
            this.grandSlamNameDataGridViewTextBoxColumn.HeaderText = "Grand Slam Name";
            this.grandSlamNameDataGridViewTextBoxColumn.Name = "grandSlamNameDataGridViewTextBoxColumn";
            // 
            // winningPlayerIDDataGridViewTextBoxColumn
            // 
            this.winningPlayerIDDataGridViewTextBoxColumn.DataPropertyName = "Winning Player ID";
            this.winningPlayerIDDataGridViewTextBoxColumn.HeaderText = "Winning Player ID";
            this.winningPlayerIDDataGridViewTextBoxColumn.Name = "winningPlayerIDDataGridViewTextBoxColumn";
            // 
            // winningPlayerNameDataGridViewTextBoxColumn
            // 
            this.winningPlayerNameDataGridViewTextBoxColumn.DataPropertyName = "Winning Player Name";
            this.winningPlayerNameDataGridViewTextBoxColumn.HeaderText = "Winning Player Name";
            this.winningPlayerNameDataGridViewTextBoxColumn.Name = "winningPlayerNameDataGridViewTextBoxColumn";
            // 
            // winningPlayerEarningsDataGridViewTextBoxColumn
            // 
            this.winningPlayerEarningsDataGridViewTextBoxColumn.DataPropertyName = "Winning Player Earnings";
            this.winningPlayerEarningsDataGridViewTextBoxColumn.HeaderText = "Winning Player Earnings";
            this.winningPlayerEarningsDataGridViewTextBoxColumn.Name = "winningPlayerEarningsDataGridViewTextBoxColumn";
            // 
            // grandSlamIDDataGridViewTextBoxColumn
            // 
            this.grandSlamIDDataGridViewTextBoxColumn.DataPropertyName = "Grand Slam ID";
            this.grandSlamIDDataGridViewTextBoxColumn.HeaderText = "Grand Slam ID";
            this.grandSlamIDDataGridViewTextBoxColumn.Name = "grandSlamIDDataGridViewTextBoxColumn";
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
            this.AdminButton.Location = new System.Drawing.Point(522, 326);
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
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SlamBox);
            this.Controls.Add(this.EarningsBox);
            this.Controls.Add(this.SortSlam);
            this.Controls.Add(this.SortEarnings);
            this.Controls.Add(this.SortButton);
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
        private System.Windows.Forms.Button SortButton;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn grandSlamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winningPlayerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winningPlayerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winningPlayerEarningsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grandSlamIDDataGridViewTextBoxColumn;
    }
}