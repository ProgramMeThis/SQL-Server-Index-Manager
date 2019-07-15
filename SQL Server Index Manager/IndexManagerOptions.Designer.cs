namespace SQL_Server_Index_Manager
{
    partial class IndexManagerOptions
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
            this.indexRebuildGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sortInTempDBCheckbox = new System.Windows.Forms.CheckBox();
            this.indexFragmentationGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reorganizeThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rebuildThresholdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimumIndexSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sqlConnectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.commandTimeoutNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.restoreDefaultsButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.indexRebuildGroupBox.SuspendLayout();
            this.indexFragmentationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reorganizeThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebuildThresholdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumIndexSizeNumericUpDown)).BeginInit();
            this.sqlConnectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandTimeoutNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // indexRebuildGroupBox
            // 
            this.indexRebuildGroupBox.Controls.Add(this.label9);
            this.indexRebuildGroupBox.Controls.Add(this.sortInTempDBCheckbox);
            this.indexRebuildGroupBox.Location = new System.Drawing.Point(11, 126);
            this.indexRebuildGroupBox.Name = "indexRebuildGroupBox";
            this.indexRebuildGroupBox.Size = new System.Drawing.Size(326, 56);
            this.indexRebuildGroupBox.TabIndex = 1;
            this.indexRebuildGroupBox.TabStop = false;
            this.indexRebuildGroupBox.Text = "Index Rebuild";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sort in tempdb:";
            // 
            // sortInTempDBCheckbox
            // 
            this.sortInTempDBCheckbox.AutoSize = true;
            this.sortInTempDBCheckbox.Checked = true;
            this.sortInTempDBCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortInTempDBCheckbox.Location = new System.Drawing.Point(128, 25);
            this.sortInTempDBCheckbox.Name = "sortInTempDBCheckbox";
            this.sortInTempDBCheckbox.Size = new System.Drawing.Size(15, 14);
            this.sortInTempDBCheckbox.TabIndex = 0;
            this.sortInTempDBCheckbox.UseVisualStyleBackColor = true;
            // 
            // indexFragmentationGroupBox
            // 
            this.indexFragmentationGroupBox.Controls.Add(this.label4);
            this.indexFragmentationGroupBox.Controls.Add(this.label7);
            this.indexFragmentationGroupBox.Controls.Add(this.label8);
            this.indexFragmentationGroupBox.Controls.Add(this.label6);
            this.indexFragmentationGroupBox.Controls.Add(this.label3);
            this.indexFragmentationGroupBox.Controls.Add(this.label2);
            this.indexFragmentationGroupBox.Controls.Add(this.reorganizeThresholdNumericUpDown);
            this.indexFragmentationGroupBox.Controls.Add(this.rebuildThresholdNumericUpDown);
            this.indexFragmentationGroupBox.Controls.Add(this.minimumIndexSizeNumericUpDown);
            this.indexFragmentationGroupBox.Location = new System.Drawing.Point(11, 12);
            this.indexFragmentationGroupBox.Name = "indexFragmentationGroupBox";
            this.indexFragmentationGroupBox.Size = new System.Drawing.Size(326, 100);
            this.indexFragmentationGroupBox.TabIndex = 0;
            this.indexFragmentationGroupBox.TabStop = false;
            this.indexFragmentationGroupBox.Text = "Index Fragmentation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reorganize threshold:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "% Fragmentation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "% Fragmentation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rebuild threshold:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum index size:";
            // 
            // reorganizeThresholdNumericUpDown
            // 
            this.reorganizeThresholdNumericUpDown.Location = new System.Drawing.Point(128, 19);
            this.reorganizeThresholdNumericUpDown.Name = "reorganizeThresholdNumericUpDown";
            this.reorganizeThresholdNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.reorganizeThresholdNumericUpDown.TabIndex = 0;
            this.reorganizeThresholdNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // rebuildThresholdNumericUpDown
            // 
            this.rebuildThresholdNumericUpDown.Location = new System.Drawing.Point(128, 43);
            this.rebuildThresholdNumericUpDown.Name = "rebuildThresholdNumericUpDown";
            this.rebuildThresholdNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.rebuildThresholdNumericUpDown.TabIndex = 1;
            this.rebuildThresholdNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // minimumIndexSizeNumericUpDown
            // 
            this.minimumIndexSizeNumericUpDown.Location = new System.Drawing.Point(128, 65);
            this.minimumIndexSizeNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minimumIndexSizeNumericUpDown.Name = "minimumIndexSizeNumericUpDown";
            this.minimumIndexSizeNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.minimumIndexSizeNumericUpDown.TabIndex = 2;
            this.minimumIndexSizeNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // sqlConnectionGroupBox
            // 
            this.sqlConnectionGroupBox.Controls.Add(this.label5);
            this.sqlConnectionGroupBox.Controls.Add(this.label1);
            this.sqlConnectionGroupBox.Controls.Add(this.commandTimeoutNumericUpDown);
            this.sqlConnectionGroupBox.Location = new System.Drawing.Point(11, 196);
            this.sqlConnectionGroupBox.Name = "sqlConnectionGroupBox";
            this.sqlConnectionGroupBox.Size = new System.Drawing.Size(326, 61);
            this.sqlConnectionGroupBox.TabIndex = 2;
            this.sqlConnectionGroupBox.TabStop = false;
            this.sqlConnectionGroupBox.Text = "SQL Connection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Command Timeout:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seconds";
            // 
            // commandTimeoutNumericUpDown
            // 
            this.commandTimeoutNumericUpDown.Location = new System.Drawing.Point(128, 19);
            this.commandTimeoutNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.commandTimeoutNumericUpDown.Name = "commandTimeoutNumericUpDown";
            this.commandTimeoutNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.commandTimeoutNumericUpDown.TabIndex = 0;
            this.commandTimeoutNumericUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // restoreDefaultsButton
            // 
            this.restoreDefaultsButton.Location = new System.Drawing.Point(12, 266);
            this.restoreDefaultsButton.Name = "restoreDefaultsButton";
            this.restoreDefaultsButton.Size = new System.Drawing.Size(107, 23);
            this.restoreDefaultsButton.TabIndex = 3;
            this.restoreDefaultsButton.Text = "Restore Defaults";
            this.restoreDefaultsButton.UseVisualStyleBackColor = true;
            this.restoreDefaultsButton.Click += new System.EventHandler(this.restoreDefaultsButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(182, 266);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(263, 266);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // IndexManagerOptions
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(349, 299);
            this.Controls.Add(this.indexFragmentationGroupBox);
            this.Controls.Add(this.sqlConnectionGroupBox);
            this.Controls.Add(this.restoreDefaultsButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.indexRebuildGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IndexManagerOptions";
            this.ShowIcon = false;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.IndexManagerOptions_Load);
            this.indexRebuildGroupBox.ResumeLayout(false);
            this.indexRebuildGroupBox.PerformLayout();
            this.indexFragmentationGroupBox.ResumeLayout(false);
            this.indexFragmentationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reorganizeThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rebuildThresholdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumIndexSizeNumericUpDown)).EndInit();
            this.sqlConnectionGroupBox.ResumeLayout(false);
            this.sqlConnectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandTimeoutNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox indexRebuildGroupBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sortInTempDBCheckbox;
        private System.Windows.Forms.NumericUpDown commandTimeoutNumericUpDown;
        private System.Windows.Forms.GroupBox indexFragmentationGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown reorganizeThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown rebuildThresholdNumericUpDown;
        private System.Windows.Forms.NumericUpDown minimumIndexSizeNumericUpDown;
        private System.Windows.Forms.GroupBox sqlConnectionGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button restoreDefaultsButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}