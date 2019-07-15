namespace SQL_Server_Index_Manager
{
    partial class IndexManager
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
            this.reanalyzeButton = new System.Windows.Forms.Button();
            this.exportDataButton = new System.Windows.Forms.Button();
            this.fixIndicesButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.indexAnalysisTabPage = new System.Windows.Forms.TabPage();
            this.indexAnalysisDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsTabPage = new System.Windows.Forms.TabPage();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.resultsStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsDatabaseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsTableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsFixColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cancelScanButton = new System.Windows.Forms.Button();
            this.scanningProgressBar = new System.Windows.Forms.ProgressBar();
            this.serverAndDatabaseNameLabel = new System.Windows.Forms.Label();
            this.scanningProgressLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.indexAnalysisTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indexAnalysisDataGridView)).BeginInit();
            this.resultsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reanalyzeButton
            // 
            this.reanalyzeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reanalyzeButton.Location = new System.Drawing.Point(32, 1178);
            this.reanalyzeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.reanalyzeButton.Name = "reanalyzeButton";
            this.reanalyzeButton.Size = new System.Drawing.Size(269, 110);
            this.reanalyzeButton.TabIndex = 0;
            this.reanalyzeButton.Text = "Reanalyze";
            this.reanalyzeButton.UseVisualStyleBackColor = true;
            this.reanalyzeButton.Click += new System.EventHandler(this.reanalyzeButton_Click);
            // 
            // exportDataButton
            // 
            this.exportDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exportDataButton.Location = new System.Drawing.Point(1288, 1178);
            this.exportDataButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exportDataButton.Name = "exportDataButton";
            this.exportDataButton.Size = new System.Drawing.Size(269, 110);
            this.exportDataButton.TabIndex = 1;
            this.exportDataButton.Text = "Export Data";
            this.exportDataButton.UseVisualStyleBackColor = true;
            this.exportDataButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // fixIndicesButton
            // 
            this.fixIndicesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fixIndicesButton.Enabled = false;
            this.fixIndicesButton.Location = new System.Drawing.Point(1573, 1178);
            this.fixIndicesButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.fixIndicesButton.Name = "fixIndicesButton";
            this.fixIndicesButton.Size = new System.Drawing.Size(269, 110);
            this.fixIndicesButton.TabIndex = 2;
            this.fixIndicesButton.Text = "Fix Indices";
            this.fixIndicesButton.UseVisualStyleBackColor = true;
            this.fixIndicesButton.Click += new System.EventHandler(this.fixIndicesButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.indexAnalysisTabPage);
            this.tabControl1.Controls.Add(this.resultsTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1811, 989);
            this.tabControl1.TabIndex = 3;
            // 
            // indexAnalysisTabPage
            // 
            this.indexAnalysisTabPage.Controls.Add(this.indexAnalysisDataGridView);
            this.indexAnalysisTabPage.Location = new System.Drawing.Point(10, 48);
            this.indexAnalysisTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.indexAnalysisTabPage.Name = "indexAnalysisTabPage";
            this.indexAnalysisTabPage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.indexAnalysisTabPage.Size = new System.Drawing.Size(1791, 931);
            this.indexAnalysisTabPage.TabIndex = 0;
            this.indexAnalysisTabPage.Text = "Index Analysis";
            this.indexAnalysisTabPage.UseVisualStyleBackColor = true;
            // 
            // indexAnalysisDataGridView
            // 
            this.indexAnalysisDataGridView.AllowUserToAddRows = false;
            this.indexAnalysisDataGridView.AllowUserToDeleteRows = false;
            this.indexAnalysisDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.indexAnalysisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.indexAnalysisDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indexAnalysisDataGridView.Location = new System.Drawing.Point(8, 7);
            this.indexAnalysisDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.indexAnalysisDataGridView.Name = "indexAnalysisDataGridView";
            this.indexAnalysisDataGridView.RowHeadersVisible = false;
            this.indexAnalysisDataGridView.Size = new System.Drawing.Size(1775, 917);
            this.indexAnalysisDataGridView.TabIndex = 0;
            this.indexAnalysisDataGridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.indexAnalysisDataGridView_CellMouseUp);
            this.indexAnalysisDataGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.indexAnalysisDataGridView_CellPainting);
            this.indexAnalysisDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.indexAnalysisDataGridView_CellValueChanged);
            this.indexAnalysisDataGridView.Sorted += new System.EventHandler(this.indexAnalysisDataGridView_Sorted);
            // 
            // resultsTabPage
            // 
            this.resultsTabPage.Controls.Add(this.resultsDataGridView);
            this.resultsTabPage.Location = new System.Drawing.Point(10, 48);
            this.resultsTabPage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resultsTabPage.Name = "resultsTabPage";
            this.resultsTabPage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resultsTabPage.Size = new System.Drawing.Size(1791, 931);
            this.resultsTabPage.TabIndex = 1;
            this.resultsTabPage.Text = "Results";
            this.resultsTabPage.UseVisualStyleBackColor = true;
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultsStatusColumn,
            this.resultsDatabaseColumn,
            this.resultsTableColumn,
            this.resultsIndexColumn,
            this.resultsFixColumn});
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.Location = new System.Drawing.Point(8, 7);
            this.resultsDataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.RowHeadersVisible = false;
            this.resultsDataGridView.Size = new System.Drawing.Size(1775, 917);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // resultsStatusColumn
            // 
            this.resultsStatusColumn.HeaderText = "Status";
            this.resultsStatusColumn.Name = "resultsStatusColumn";
            this.resultsStatusColumn.ReadOnly = true;
            // 
            // resultsDatabaseColumn
            // 
            this.resultsDatabaseColumn.HeaderText = "Database";
            this.resultsDatabaseColumn.Name = "resultsDatabaseColumn";
            this.resultsDatabaseColumn.ReadOnly = true;
            // 
            // resultsTableColumn
            // 
            this.resultsTableColumn.HeaderText = "Table";
            this.resultsTableColumn.Name = "resultsTableColumn";
            this.resultsTableColumn.ReadOnly = true;
            // 
            // resultsIndexColumn
            // 
            this.resultsIndexColumn.HeaderText = "Index";
            this.resultsIndexColumn.Name = "resultsIndexColumn";
            this.resultsIndexColumn.ReadOnly = true;
            // 
            // resultsFixColumn
            // 
            this.resultsFixColumn.HeaderText = "Fix";
            this.resultsFixColumn.Name = "resultsFixColumn";
            this.resultsFixColumn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1875, 55);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToSQLServerToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // connectToSQLServerToolStripMenuItem
            // 
            this.connectToSQLServerToolStripMenuItem.Name = "connectToSQLServerToolStripMenuItem";
            this.connectToSQLServerToolStripMenuItem.Size = new System.Drawing.Size(430, 46);
            this.connectToSQLServerToolStripMenuItem.Text = "&Connect to SQL Server";
            this.connectToSQLServerToolStripMenuItem.Click += new System.EventHandler(this.connectToSQLServerToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(430, 46);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(427, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(430, 46);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 46);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(32, 64);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cancelScanButton);
            this.splitContainer1.Panel1.Controls.Add(this.scanningProgressBar);
            this.splitContainer1.Panel1.Controls.Add(this.serverAndDatabaseNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.scanningProgressLabel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1811, 1099);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 5;
            // 
            // cancelScanButton
            // 
            this.cancelScanButton.Location = new System.Drawing.Point(1587, 12);
            this.cancelScanButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cancelScanButton.Name = "cancelScanButton";
            this.cancelScanButton.Size = new System.Drawing.Size(200, 83);
            this.cancelScanButton.TabIndex = 3;
            this.cancelScanButton.Text = "Cancel";
            this.cancelScanButton.UseVisualStyleBackColor = true;
            this.cancelScanButton.Visible = false;
            this.cancelScanButton.Click += new System.EventHandler(this.cancelScanButton_Click);
            // 
            // scanningProgressBar
            // 
            this.scanningProgressBar.Location = new System.Drawing.Point(1019, 12);
            this.scanningProgressBar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.scanningProgressBar.Name = "scanningProgressBar";
            this.scanningProgressBar.Size = new System.Drawing.Size(552, 81);
            this.scanningProgressBar.TabIndex = 2;
            this.scanningProgressBar.Visible = false;
            // 
            // serverAndDatabaseNameLabel
            // 
            this.serverAndDatabaseNameLabel.AutoSize = true;
            this.serverAndDatabaseNameLabel.Location = new System.Drawing.Point(613, 38);
            this.serverAndDatabaseNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.serverAndDatabaseNameLabel.Name = "serverAndDatabaseNameLabel";
            this.serverAndDatabaseNameLabel.Size = new System.Drawing.Size(378, 32);
            this.serverAndDatabaseNameLabel.TabIndex = 1;
            this.serverAndDatabaseNameLabel.Text = "ServerName.DatabaseName";
            this.serverAndDatabaseNameLabel.Visible = false;
            // 
            // scanningProgressLabel
            // 
            this.scanningProgressLabel.AutoSize = true;
            this.scanningProgressLabel.Location = new System.Drawing.Point(45, 38);
            this.scanningProgressLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.scanningProgressLabel.Name = "scanningProgressLabel";
            this.scanningProgressLabel.Size = new System.Drawing.Size(418, 32);
            this.scanningProgressLabel.TabIndex = 0;
            this.scanningProgressLabel.Text = "Scanned __ Inidices in 00:00:00";
            this.scanningProgressLabel.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // IndexManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 1316);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.fixIndicesButton);
            this.Controls.Add(this.exportDataButton);
            this.Controls.Add(this.reanalyzeButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "IndexManager";
            this.Text = "Index Manager";
            this.Load += new System.EventHandler(this.IndexManager_Load);
            this.ResizeEnd += new System.EventHandler(this.IndexManager_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.IndexManager_SizeChanged);
            this.tabControl1.ResumeLayout(false);
            this.indexAnalysisTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indexAnalysisDataGridView)).EndInit();
            this.resultsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reanalyzeButton;
        private System.Windows.Forms.Button exportDataButton;
        private System.Windows.Forms.Button fixIndicesButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage indexAnalysisTabPage;
        private System.Windows.Forms.TabPage resultsTabPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView indexAnalysisDataGridView;
        private System.Windows.Forms.ProgressBar scanningProgressBar;
        private System.Windows.Forms.Label serverAndDatabaseNameLabel;
        private System.Windows.Forms.Label scanningProgressLabel;
        private System.Windows.Forms.Button cancelScanButton;
        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsDatabaseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsTableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultsFixColumn;
    }
}