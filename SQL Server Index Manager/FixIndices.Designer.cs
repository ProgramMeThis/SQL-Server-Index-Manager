namespace SQL_Server_Index_Manager
{
    partial class FixIndices
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.summaryLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sqlScriptTextBox = new System.Windows.Forms.RichTextBox();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            this.sqlScriptTextBoxBad = new System.Windows.Forms.TextBox();
            this.fixNowButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1659, 987);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage1.Location = new System.Drawing.Point(42, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage1.Size = new System.Drawing.Size(1613, 979);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto Fix";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(953, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server Administrator Laboratory will try to fix the indexes you selected";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.summaryLabel);
            this.groupBox1.Location = new System.Drawing.Point(24, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1541, 904);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQL_Server_Index_Manager.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(16, 813);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 837);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(773, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Server performance may decline while your fixes are applied";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Location = new System.Drawing.Point(16, 60);
            this.summaryLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(383, 32);
            this.summaryLabel.TabIndex = 2;
            this.summaryLabel.Text = "Rebuilding and Reorganizing";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sqlScriptTextBox);
            this.tabPage2.Controls.Add(this.copyToClipboardButton);
            this.tabPage2.Controls.Add(this.sqlScriptTextBoxBad);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage2.Location = new System.Drawing.Point(42, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1613, 979);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Get SQL Script";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlScriptTextBox
            // 
            this.sqlScriptTextBox.Location = new System.Drawing.Point(43, 19);
            this.sqlScriptTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sqlScriptTextBox.Name = "sqlScriptTextBox";
            this.sqlScriptTextBox.ReadOnly = true;
            this.sqlScriptTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.sqlScriptTextBox.Size = new System.Drawing.Size(1548, 860);
            this.sqlScriptTextBox.TabIndex = 4;
            this.sqlScriptTextBox.Text = "";
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(1285, 894);
            this.copyToClipboardButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(280, 55);
            this.copyToClipboardButton.TabIndex = 3;
            this.copyToClipboardButton.Text = "Copy to Clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.copyToClipboardButton_Click);
            // 
            // sqlScriptTextBoxBad
            // 
            this.sqlScriptTextBoxBad.Location = new System.Drawing.Point(43, 19);
            this.sqlScriptTextBoxBad.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.sqlScriptTextBoxBad.Multiline = true;
            this.sqlScriptTextBoxBad.Name = "sqlScriptTextBoxBad";
            this.sqlScriptTextBoxBad.ReadOnly = true;
            this.sqlScriptTextBoxBad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlScriptTextBoxBad.Size = new System.Drawing.Size(1548, 860);
            this.sqlScriptTextBoxBad.TabIndex = 0;
            // 
            // fixNowButton
            // 
            this.fixNowButton.Location = new System.Drawing.Point(1211, 1002);
            this.fixNowButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fixNowButton.Name = "fixNowButton";
            this.fixNowButton.Size = new System.Drawing.Size(200, 55);
            this.fixNowButton.TabIndex = 1;
            this.fixNowButton.Text = "Fix now";
            this.fixNowButton.UseVisualStyleBackColor = true;
            this.fixNowButton.Click += new System.EventHandler(this.fixNowButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(1427, 1002);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(200, 55);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FixIndices
            // 
            this.AcceptButton = this.fixNowButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1659, 1071);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fixNowButton);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FixIndices";
            this.Text = "Fix Indices";
            this.Load += new System.EventHandler(this.FixIndices_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label summaryLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button copyToClipboardButton;
        private System.Windows.Forms.TextBox sqlScriptTextBoxBad;
        private System.Windows.Forms.Button fixNowButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RichTextBox sqlScriptTextBox;
    }
}