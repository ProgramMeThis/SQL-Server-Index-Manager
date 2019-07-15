namespace SQL_Server_Index_Manager
{
    partial class DatabaseConnectionProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnectionProperties));
            this.serverNameComboBox = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.useSQLServerAuthenticationRadioButton = new System.Windows.Forms.RadioButton();
            this.useWindowsAuthenticationRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.databaseTableGroupBox = new System.Windows.Forms.GroupBox();
            this.databaseNameComboBox = new System.Windows.Forms.ComboBox();
            this.databaseNameCheckBox = new System.Windows.Forms.CheckBox();
            this.testConnectionButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.databaseTableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverNameComboBox
            // 
            this.serverNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.serverNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.serverNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNameComboBox.FormattingEnabled = true;
            this.serverNameComboBox.Location = new System.Drawing.Point(12, 49);
            this.serverNameComboBox.Name = "serverNameComboBox";
            this.serverNameComboBox.Size = new System.Drawing.Size(325, 23);
            this.serverNameComboBox.TabIndex = 0;
            this.serverNameComboBox.DropDown += new System.EventHandler(this.serverNameComboBox_DropDown);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(343, 46);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 28);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.userNameLabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.useSQLServerAuthenticationRadioButton);
            this.groupBox1.Controls.Add(this.useWindowsAuthenticationRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 128);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log on to the server";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Enabled = false;
            this.passwordLabel.Location = new System.Drawing.Point(27, 97);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Enabled = false;
            this.userNameLabel.Location = new System.Drawing.Point(22, 71);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(61, 13);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Enabled = false;
            this.userNameTextBox.Location = new System.Drawing.Point(89, 68);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(318, 20);
            this.userNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(89, 94);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(318, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // useSQLServerAuthenticationRadioButton
            // 
            this.useSQLServerAuthenticationRadioButton.AutoSize = true;
            this.useSQLServerAuthenticationRadioButton.Location = new System.Drawing.Point(6, 42);
            this.useSQLServerAuthenticationRadioButton.Name = "useSQLServerAuthenticationRadioButton";
            this.useSQLServerAuthenticationRadioButton.Size = new System.Drawing.Size(173, 17);
            this.useSQLServerAuthenticationRadioButton.TabIndex = 1;
            this.useSQLServerAuthenticationRadioButton.Text = "Use SQL Server Authentication";
            this.useSQLServerAuthenticationRadioButton.UseVisualStyleBackColor = true;
            this.useSQLServerAuthenticationRadioButton.CheckedChanged += new System.EventHandler(this.useSQLServerAuthentication_CheckedChanged);
            // 
            // useWindowsAuthenticationRadioButton
            // 
            this.useWindowsAuthenticationRadioButton.AutoSize = true;
            this.useWindowsAuthenticationRadioButton.Checked = true;
            this.useWindowsAuthenticationRadioButton.Location = new System.Drawing.Point(6, 19);
            this.useWindowsAuthenticationRadioButton.Name = "useWindowsAuthenticationRadioButton";
            this.useWindowsAuthenticationRadioButton.Size = new System.Drawing.Size(162, 17);
            this.useWindowsAuthenticationRadioButton.TabIndex = 0;
            this.useWindowsAuthenticationRadioButton.TabStop = true;
            this.useWindowsAuthenticationRadioButton.Text = "Use Windows Authentication";
            this.useWindowsAuthenticationRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter information to connect to the data source";
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Location = new System.Drawing.Point(12, 33);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(70, 13);
            this.serverNameLabel.TabIndex = 4;
            this.serverNameLabel.Text = "Server name:";
            // 
            // databaseTableGroupBox
            // 
            this.databaseTableGroupBox.Controls.Add(this.databaseNameComboBox);
            this.databaseTableGroupBox.Controls.Add(this.databaseNameCheckBox);
            this.databaseTableGroupBox.Location = new System.Drawing.Point(12, 214);
            this.databaseTableGroupBox.Name = "databaseTableGroupBox";
            this.databaseTableGroupBox.Size = new System.Drawing.Size(413, 79);
            this.databaseTableGroupBox.TabIndex = 5;
            this.databaseTableGroupBox.TabStop = false;
            this.databaseTableGroupBox.Text = "Connect to a database";
            // 
            // databaseNameComboBox
            // 
            this.databaseNameComboBox.Enabled = false;
            this.databaseNameComboBox.FormattingEnabled = true;
            this.databaseNameComboBox.Location = new System.Drawing.Point(7, 43);
            this.databaseNameComboBox.Name = "databaseNameComboBox";
            this.databaseNameComboBox.Size = new System.Drawing.Size(399, 21);
            this.databaseNameComboBox.TabIndex = 1;
            this.databaseNameComboBox.DropDown += new System.EventHandler(this.databaseNameComboBox_DropDown);
            // 
            // databaseNameCheckBox
            // 
            this.databaseNameCheckBox.AutoSize = true;
            this.databaseNameCheckBox.Location = new System.Drawing.Point(7, 20);
            this.databaseNameCheckBox.Name = "databaseNameCheckBox";
            this.databaseNameCheckBox.Size = new System.Drawing.Size(183, 17);
            this.databaseNameCheckBox.TabIndex = 0;
            this.databaseNameCheckBox.Text = "Select or enter a database name:";
            this.databaseNameCheckBox.UseVisualStyleBackColor = true;
            this.databaseNameCheckBox.CheckedChanged += new System.EventHandler(this.databaseNameCheckBox_CheckedChanged);
            // 
            // testConnectionButton
            // 
            this.testConnectionButton.Location = new System.Drawing.Point(18, 306);
            this.testConnectionButton.Name = "testConnectionButton";
            this.testConnectionButton.Size = new System.Drawing.Size(94, 28);
            this.testConnectionButton.TabIndex = 6;
            this.testConnectionButton.Text = "Test Connection";
            this.testConnectionButton.UseVisualStyleBackColor = true;
            this.testConnectionButton.Click += new System.EventHandler(this.testConnectionButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(262, 306);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 28);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(343, 306);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(18, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 11;
            // 
            // DatabaseConnectionProperties
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.testConnectionButton);
            this.Controls.Add(this.databaseTableGroupBox);
            this.Controls.Add(this.serverNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.serverNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseConnectionProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection Properties";
            this.Load += new System.EventHandler(this.DatabaseConnectionProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.databaseTableGroupBox.ResumeLayout(false);
            this.databaseTableGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverNameComboBox;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.RadioButton useSQLServerAuthenticationRadioButton;
        private System.Windows.Forms.RadioButton useWindowsAuthenticationRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.GroupBox databaseTableGroupBox;
        private System.Windows.Forms.ComboBox databaseNameComboBox;
        private System.Windows.Forms.CheckBox databaseNameCheckBox;
        private System.Windows.Forms.Button testConnectionButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel1;
    }
}