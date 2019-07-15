using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQL_Server_Index_Manager
{
    public partial class IndexManagerOptions : Form
    {
        public IndexManagerOptions()
        {
            InitializeComponent();
        }

        private void IndexManagerOptions_Load(object sender, EventArgs e)
        {
            reorganizeThresholdNumericUpDown.Value = Properties.Settings.Default.IndexManagerReorganizeThreshold;
            rebuildThresholdNumericUpDown.Value = Properties.Settings.Default.IndexManagerRebuildThreshold;
            minimumIndexSizeNumericUpDown.Value = Properties.Settings.Default.IndexManagerMinimumIndexSize;
            sortInTempDBCheckbox.Checked = Properties.Settings.Default.IndexManagerSortInTempDB;
            commandTimeoutNumericUpDown.Value = Properties.Settings.Default.IndexManagerCommandTimeout;
        }

        private void restoreDefaultsButton_Click(object sender, EventArgs e)
        {
            reorganizeThresholdNumericUpDown.Value = 10;
            rebuildThresholdNumericUpDown.Value = 30;
            minimumIndexSizeNumericUpDown.Value = 100;
            sortInTempDBCheckbox.Checked = true;
            commandTimeoutNumericUpDown.Value = 600;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IndexManagerReorganizeThreshold = Convert.ToInt32(reorganizeThresholdNumericUpDown.Value);
            Properties.Settings.Default.IndexManagerRebuildThreshold = Convert.ToInt32(rebuildThresholdNumericUpDown.Value);
            Properties.Settings.Default.IndexManagerMinimumIndexSize = Convert.ToInt32(minimumIndexSizeNumericUpDown.Value);
            Properties.Settings.Default.IndexManagerSortInTempDB = sortInTempDBCheckbox.Checked;
            Properties.Settings.Default.IndexManagerCommandTimeout = Convert.ToInt32(commandTimeoutNumericUpDown.Value);
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
