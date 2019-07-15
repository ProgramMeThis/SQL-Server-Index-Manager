using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using System.Xml;

namespace SQL_Server_Index_Manager
{
    public partial class IndexManager : Form
    {
        SqlConnection indexManagerSQLConnection = new SqlConnection();
        private int beginningWidth = 0;
        private int beginningHeight = 0;
        private string sqlServerVersion = "";


        internal SqlConnection IndexManagerSQLConnection
        {
            set { indexManagerSQLConnection = value; }
        }

        public IndexManager()
        {
            InitializeComponent();
        }

        private void IndexManager_Load(object sender, EventArgs e)
        {
            beginningWidth = this.Width;
            beginningHeight = this.Height;

            //if (indexManagerSQLConnection != null)
            //{
            //    connectToDatabaseAndScan();
            //}
        }

        private void connectToSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlConnectionString = getConnectionStringFromDialog("", "", false);
            if (sqlConnectionString != null)
            {
                indexManagerSQLConnection = new SqlConnection(sqlConnectionString);
                connectToDatabaseAndScan();
            }
        }

        DateTime startTime = new DateTime();
        private void connectToDatabaseAndScan()
        {
            resetScreen();

            startTime = DateTime.Now;
            serverAndDatabaseNameLabel.Text = indexManagerSQLConnection.DataSource + "." + indexManagerSQLConnection.Database;
            serverAndDatabaseNameLabel.Visible = true;

            resultsDataGridView.Rows.Clear();
            DataView results = scanIndices();
            indexAnalysisDataGridView.DataSource = results;

            for (int i = 0; i < indexAnalysisDataGridView.Columns.Count; i++)
            {
                indexAnalysisDataGridView.Columns[i].ReadOnly = true;
            }

            indexAnalysisDataGridView.Columns["Selection"].ReadOnly = false;
            indexAnalysisDataGridView.Columns["Schema"].Visible = false;
            indexAnalysisDataGridView.Columns["objectid"].Visible = false;
            indexAnalysisDataGridView.Columns["indexid"].Visible = false;
            indexAnalysisDataGridView.Columns["partitionnum"].Visible = false;

            //colorCodeCells();

            TimeSpan ts = DateTime.Now - startTime;
            scanningProgressLabel.Text = "Scanned " + results.Count + " indices in " + ts.ToString(@"hh\:mm\:ss\.ff");
            scanningProgressLabel.Visible = true;
        }

        private void colorCodeCells()
        {
            try
            {
                for (int i = 0; i < indexAnalysisDataGridView.Rows.Count; i++)
                {
                    //color index size
                    //color priority
                    if (indexAnalysisDataGridView.Rows[i].Cells["Action Required"].Value.ToString() != "None")
                    {
                        float percentage = Convert.ToSingle(indexAnalysisDataGridView.Rows[i].Cells["Index Fragmentation %"].Value) / 100f;
                        int redColor = (percentage > 0.5 ? 255 : Convert.ToInt32(percentage * 255f));
                        int greenColor = (percentage < 0.5 ? 255 : Convert.ToInt32(255f - (percentage * 255f)));
                        int blueColor = 0;
                        Color cellColor = Color.FromArgb(redColor, greenColor, blueColor);
                        indexAnalysisDataGridView.Rows[i].Cells["Priority"].Style.BackColor = cellColor;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred. Error:" + exc.Message);
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndexManagerOptions imo = new IndexManagerOptions();
            imo.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelScanButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        //scanning needs to be done in the background so that it can be cancelled and won't freeze the application
        private DataView scanIndices()
        {
            DataView dv = new DataView();

            using (SqlConnection tempSqlConnection = new SqlConnection(indexManagerSQLConnection.ConnectionString))
            {
                using (SqlCommand getSqlVersionSQLCommand = new SqlCommand("select @@version", tempSqlConnection))
                {
                    getSqlVersionSQLCommand.Connection.Open();

                    try
                    {
                        object result = getSqlVersionSQLCommand.ExecuteScalar();
                        if (result != null)
                        {
                            if (result.ToString() != "")
                            {
                                sqlServerVersion = result.ToString().Substring(0, (result.ToString().Length - (result.ToString().Length - (result.ToString().IndexOf('-') - 1))));
                            }

                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("An error occurred grabbing the sql server version. Error: " + exc.Message, "An Error has Occurred");
                    }
                    finally
                    {
                        getSqlVersionSQLCommand.Connection.Close();
                    }
                }

                //string sqlSelectString = "select DB_NAME() as 'Database', (select name from sys.objects where object_id = physicalStats.object_id) as 'Table', (select name from sys.indexes where index_id = physicalStats.index_id and physicalStats.object_id = OBJECT_ID) as 'Index', page_count as 'Index Size (Pages)', round(avg_fragmentation_in_percent, 2) AS 'Index Fragmentation %', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'None' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'None' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Reorganize Index' else 'Rebuild Index' end) as 'Action Required', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Page Count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + "' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Fragmentation < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Fragmentation >= " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' else 'Fragmentation >= " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + "%' end) as 'Reason', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Low' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Low' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Medium' else 'High' end) as 'Priority', cast(0 as bit) as 'Selection', physicalStats.object_id AS objectid, physicalStats.index_id AS indexid, partition_number AS partitionnum from sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL , NULL, 'LIMITED') as physicalStats";
                string sqlSelectString = "DECLARE @database_id INT; set @database_id = DB_ID(); select DB_NAME() as 'Database', OBJECT_SCHEMA_NAME(OBJECT_ID) as 'Schema', OBJECT_NAME(OBJECT_ID) as 'Table', (select name from sys.indexes where index_id = physicalStats.index_id and physicalStats.object_id = OBJECT_ID) as 'Index', page_count as 'Index Size (Pages)', round(avg_fragmentation_in_percent, 2) AS 'Index Fragmentation %', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'None' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'None' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Reorganize Index' else 'Rebuild Index' end) as 'Action Required', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Page Count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + "' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Fragmentation < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Fragmentation >= " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' else 'Fragmentation >= " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + "%' end) as 'Reason', (case when page_count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Low' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Low' when avg_fragmentation_in_percent < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Medium' else 'High' end) as 'Priority', cast(0 as bit) as 'Selection', physicalStats.object_id AS objectid, physicalStats.index_id AS indexid, partition_number AS partitionnum from sys.dm_db_index_physical_stats(@database_id, NULL, NULL , NULL, 'LIMITED') as physicalStats where index_type_desc <> 'HEAP'";
                if (sqlServerVersion.Contains("2000"))
                {
                    sqlSelectString = @"-- Declare variables
SET NOCOUNT ON
DECLARE @tablename varchar (128)

-- Declare cursor
DECLARE tables CURSOR FOR
   SELECT TABLE_NAME
   FROM INFORMATION_SCHEMA.TABLES
   WHERE TABLE_TYPE = 'BASE TABLE'
-- Do not scan common table indexes
        AND TABLE_NAME NOT LIKE 'xdl%'
        AND TABLE_NAME NOT LIKE 'Prf_%'


-- Create the table
CREATE TABLE #fraglist (
   ObjectName varchar(255),
   ObjectId int,
   IndexName varchar(255),
   IndexId int,
   Lvl int,
   CountPages int,
   CountRows int,
   MinRecSize int,
   MaxRecSize int,
   AvgRecSize int,
   ForRecCount int,
   Extents int,
   ExtentSwitches int,
   AvgFreeBytes int,
   AvgPageDensity int,
   ScanDensity numeric(8, 3),
   BestCount int,
   ActualCount int,
   LogicalFrag numeric(8, 3),
   ExtentFrag numeric(8, 3)
)
 
--Open the cursor
OPEN tables


--Loop through all the tables in the database
FETCH NEXT FROM tables INTO @tablename


WHILE(@@FETCH_STATUS = 0) BEGIN
-- Do the showcontig of all indexes of the table
  INSERT INTO #fraglist 
   EXEC ('DBCC SHOWCONTIG (''' + @tablename + ''') WITH FAST, TABLERESULTS, ALL_INDEXES, NO_INFOMSGS')
   FETCH NEXT FROM tables INTO @tablename
END

-- Close and deallocate the cursor
CLOSE tables
DEALLOCATE tables

select DB_NAME() as 'Database', (select sysusers.name from sysobjects inner join sysusers on sysusers.uid = sysobjects.uid where #fraglist.objectid = sysobjects.id) as 'Schema', ObjectName as 'Table', IndexName as 'Index', CountPages as 'Index Size (Pages)', round(LogicalFrag, 2) as 'Index Fragmentation %', (case when CountPages < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'None' when LogicalFrag < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'None' when LogicalFrag < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Reorganize Index' else 'Rebuild Index' end) as 'Action Required', (case when CountPages < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Page Count < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + "' when LogicalFrag < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Fragmentation < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' when LogicalFrag < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + " then 'Fragmentation >= " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + "%' else 'Fragmentation >= " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + "%' end) as 'Reason', (case when CountPages < " + Properties.Settings.Default.IndexManagerMinimumIndexSize.ToString() + " then 'Low' when LogicalFrag < " + Properties.Settings.Default.IndexManagerReorganizeThreshold.ToString() + " then 'Low' when LogicalFrag < " + Properties.Settings.Default.IndexManagerRebuildThreshold.ToString() + @" then 'Medium' else 'High' end) as 'Priority', cast(0 as bit) as 'Selection', ObjectId as 'objectid', IndexId as indexid, NULL as partitionnum from #fraglist
where IndexName <> ''

-- Delete the temporary table
DROP TABLE #fraglist";
                }

                try
                {
                    using (SqlCommand tempSqlCommand = new SqlCommand(sqlSelectString, tempSqlConnection))
                    {
                        SqlDataAdapter sqlda = new SqlDataAdapter(tempSqlCommand);
                        DataSet ds = new DataSet();
                        sqlda.Fill(ds);
                        dv = new DataView(ds.Tables[0]);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occurred. Error: " + exc.Message);
                }
            }

            return dv;
        }

        private void ckBox_CheckedChanged(object sender, EventArgs e)
        {

            for (int j = 0; j < resultsDataGridView.RowCount; j++)
            {
                resultsDataGridView[0, j].Value = ((CheckBox)sender).Checked;
            }

            this.resultsDataGridView.EndEdit();
        }

        private void IndexManager_SizeChanged(object sender, EventArgs e)
        {
            splitContainer1.Width += this.Width - beginningWidth;
            beginningWidth = this.Width;

            splitContainer1.Height += this.Height - beginningHeight;
            beginningHeight = this.Height;
        }

        private void IndexManager_ResizeEnd(object sender, EventArgs e)
        {
            splitContainer1.Width += this.Width - beginningWidth;
            beginningWidth = this.Width;

            splitContainer1.Height += this.Height - beginningHeight;
            beginningHeight = this.Height;
        }

        private void reanalyzeButton_Click(object sender, EventArgs e)
        {
            fixIndicesButton.Enabled = false;
            connectToDatabaseAndScan();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Control resultingControl = findControlByType(tabControl1.SelectedTab, typeof(DataGridView));
            if (resultingControl != null)
            {
                SaveDataGridToFile((DataGridView)resultingControl, null, null);
            }
            else
            {
                MessageBox.Show("An error occurred trying to export the datagrid.", "Error Saving");
            }
        }

        //int checkboxCheckedCount = 0;
        //int rebuildCount = 0;
        //int reorganizeCount = 0;

        ArrayList rebuildArrayList = new ArrayList();
        ArrayList reorganizeArrayList = new ArrayList();
        private void indexAnalysisDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            object checkboxChecked = indexAnalysisDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            bool result;
            if (Boolean.TryParse(checkboxChecked.ToString(), out result))
            {
                string itemToAddOrRemove = "[" + indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Database"].Value.ToString() + "].[" + indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Schema"].Value.ToString() + "].[" + indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Table"].Value.ToString() + "].[" + indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Index"].Value.ToString() + "]";
                if (result)
                {
                    //checkboxCheckedCount++;

                    //if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Reorganize"))
                    //{
                    //    reorganizeCount++;
                    //}
                    //else if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Rebuild"))
                    //{
                    //    rebuildCount++;
                    //}

                    if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Reorganize"))
                    {
                        reorganizeArrayList.Add(itemToAddOrRemove);
                    }
                    else if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Rebuild"))
                    {
                        rebuildArrayList.Add(itemToAddOrRemove);
                    }
                }
                else
                {
                    //checkboxCheckedCount--;

                    //if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Reorganize"))
                    //{
                    //    reorganizeCount--;
                    //}
                    //else if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Rebuild"))
                    //{
                    //    rebuildCount--;
                    //}

                    if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Reorganize"))
                    {
                        reorganizeArrayList.Remove(itemToAddOrRemove);
                    }
                    else if (indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString().Contains("Rebuild"))
                    {
                        rebuildArrayList.Remove(itemToAddOrRemove);
                    }
                }

                //if (checkboxCheckedCount > 0)
                //{
                //    fixIndicesButton.Enabled = true;
                //}
                //else
                //{
                //    fixIndicesButton.Enabled = false;
                //}

                if (rebuildArrayList.Count > 0 || reorganizeArrayList.Count > 0)
                {
                    fixIndicesButton.Enabled = true;
                }
                else
                {
                    fixIndicesButton.Enabled = false;
                }
            }
        }

        private void fixIndicesButton_Click(object sender, EventArgs e)
        {
            using (FixIndices fixIndicesForm = new FixIndices())
            {
                fixIndicesForm.IndexManagerSQLConnection = indexManagerSQLConnection;
                fixIndicesForm.serverAndDatabaseName = serverAndDatabaseNameLabel.Text;
                fixIndicesForm.rebuildList = rebuildArrayList;
                fixIndicesForm.reorganizeList = reorganizeArrayList;
                fixIndicesForm.sqlServerVersion = sqlServerVersion;
                if (fixIndicesForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int currentNumberAlreadyProcessed = resultsDataGridView.Rows.Count;
                    tabControl1.SelectedTab = resultsTabPage;
                    foreach (string rebuildIndex in rebuildArrayList)
                    {
                        string[] indexArray = rebuildIndex.Split('.');
                        DataGridViewRow row = (DataGridViewRow)resultsDataGridView.RowTemplate.Clone();
                        row.CreateCells(resultsDataGridView, "Queued", removeSquareBrackets(indexArray[0]), removeSquareBrackets(indexArray[2]), removeSquareBrackets(indexArray[3]), "Rebuild");
                        resultsDataGridView.Rows.Add(row);
                    }

                    foreach (string reorganizeIndex in reorganizeArrayList)
                    {
                        string[] indexArray = reorganizeIndex.Split('.');
                        DataGridViewRow row = (DataGridViewRow)resultsDataGridView.RowTemplate.Clone();
                        row.CreateCells(resultsDataGridView, "Queued", removeSquareBrackets(indexArray[0]), removeSquareBrackets(indexArray[2]), removeSquareBrackets(indexArray[3]), "Reorganize");
                        resultsDataGridView.Rows.Add(row);
                    }

                    resultsDataGridView.Rows[0 + currentNumberAlreadyProcessed].Cells[0].Value = "Running";
                    Application.DoEvents();

                    using (SqlConnection tempSqlConnection = new SqlConnection(indexManagerSQLConnection.ConnectionString))
                    {
                        try
                        {
                            tempSqlConnection.Open();
                            //foreach (string rebuildIndex in rebuildArrayList)
                            for (int i = 0; i < rebuildArrayList.Count; i++)
                            {
                                ServerConnection svrConnection = new ServerConnection(tempSqlConnection);
                                Server server = new Server(svrConnection);
                                ArrayList tempArrayList = new ArrayList();
                                //tempArrayList.Add(rebuildIndex);
                                tempArrayList.Add(rebuildArrayList[i]);

                                try
                                {
                                    server.ConnectionContext.ExecuteNonQuery(fixIndicesForm.generateSQLScript(new ArrayList(), tempArrayList));
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].Value = "Completed";
                                }
                                catch (Exception exc)
                                {
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].Value = "Error";
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].ErrorText = exc.Message;
                                }
                                if (i < rebuildArrayList.Count - 1)
                                {
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed + 1].Cells[0].Value = "Running";
                                }
                                Application.DoEvents();
                            }

                            //foreach (string reorganizeIndex in reorganizeArrayList)
                            for (int i = 0; i < reorganizeArrayList.Count; i++)
                            {
                                ServerConnection svrConnection = new ServerConnection(tempSqlConnection);
                                Server server = new Server(svrConnection);
                                ArrayList tempArrayList = new ArrayList();
                                //tempArrayList.Add(reorganizeIndex);
                                tempArrayList.Add(reorganizeArrayList[i]);
                                try
                                {
                                    server.ConnectionContext.ExecuteNonQuery(fixIndicesForm.generateSQLScript(tempArrayList, new ArrayList()));
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].Value = "Completed";
                                }
                                catch (Exception exc)
                                {
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].Value = "Error";
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed].Cells[0].ErrorText = exc.Message;
                                }

                                if (i < reorganizeArrayList.Count - 1)
                                {
                                    resultsDataGridView.Rows[i + currentNumberAlreadyProcessed + 1].Cells[0].Value = "Running";
                                }
                                Application.DoEvents();
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("An error occurred. Error:" + exc.Message, "An Error Occurred");
                        }
                        finally
                        {
                            tempSqlConnection.Close();
                        }
                    }

                    reanalyzeProcessedRowsAndUnSelect();
                }
            }
        }

        private void indexAnalysisDataGridView_Sorted(object sender, EventArgs e)
        {
            //colorCodeCells();
        }

        private void resetScreen()
        {
            rebuildArrayList = new ArrayList();
            reorganizeArrayList = new ArrayList();
            fixIndicesButton.Enabled = false;

            indexAnalysisDataGridView.DataSource = null;
            indexAnalysisDataGridView.Rows.Clear();
        }

        private void indexAnalysisDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (indexAnalysisDataGridView.Columns[e.ColumnIndex].HeaderText == "Priority")
            {
                if (e.RowIndex >= 0 && indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Action Required"].Value.ToString() != "None")
                {
                    float percentage = Convert.ToSingle(indexAnalysisDataGridView.Rows[e.RowIndex].Cells["Index Fragmentation %"].Value) / 100f;

                    int redColor = (percentage > 0.5 ? 255 : Convert.ToInt32(percentage * 255f));
                    int greenColor = (percentage < 0.5 ? 255 : Convert.ToInt32(255f - (percentage * 255f)));
                    int blueColor = 0;
                    Color c1 = Color.FromArgb(redColor, greenColor, blueColor);



                    Color c3 = Color.FromArgb(255, 255, 255);

                    Color cellColor = Color.FromArgb(redColor, greenColor, blueColor);

                    Rectangle colorBoundaries = e.CellBounds;
                    colorBoundaries.Width = colorBoundaries.Width - 1;
                    colorBoundaries.Height = colorBoundaries.Height - 1;
                    LinearGradientBrush br = new LinearGradientBrush(e.CellBounds, c1, c3, 0, true);
                    ColorBlend cb = new ColorBlend();
                    cb.Positions = new[] { 0f, 1 };
                    cb.Colors = new[] { c1, c3 };
                    br.InterpolationColors = cb;


                    e.Graphics.FillRectangle(br, colorBoundaries);
                    e.PaintContent(e.ClipBounds);
                    e.Handled = true;
                }
            }
        }

        private string removeSquareBrackets(string inputString)
        {
            return inputString.Replace("[", "").Replace("]", "");
        }

        private void indexAnalysisDataGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == indexAnalysisDataGridView.Columns["Selection"].Index && e.RowIndex != -1)
            {
                indexAnalysisDataGridView.EndEdit();
            }
        }

        private void reanalyzeProcessedRowsAndUnSelect()
        {
            for (int i = 0; i < resultsDataGridView.Rows.Count; i++)
            {
                if ((bool)indexAnalysisDataGridView.Rows[i].Cells["Selection"].Value == true)
                {
                    indexAnalysisDataGridView.Rows[i].Cells["Selection"].Value = false;
                }
            }
        }

        private void reanalyzeIndividualIndex()
        {

        }

        internal static string getConnectionStringFromDialog(string server, string authenticationType, bool chooseServerOnly)
        {
            DatabaseConnectionProperties dcp = new DatabaseConnectionProperties();
            dcp.ChooseDBServerOnly = chooseServerOnly;
            dcp.DatabaseServerName = server;

            if (dcp.ShowDialog() == DialogResult.OK)
            {
                return dcp.ResultingSQLConnection.ConnectionString;
            }
            else
            {
                return null;
            }

        }

        internal static Control findControlByType(Control controlToSearchIn, Type controlType)
        {
            Control controlToReturn = null;

            foreach (Control control in controlToSearchIn.Controls)
            {
                if (control.GetType() == controlType)
                {
                    return control;
                }
            }

            return controlToReturn;
        }

        internal static bool SaveDataGridToFile(DataGridView dataGridView, DoWorkEventArgs e, BackgroundWorker bgWorker)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Separated Values|*.csv|Excel File|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (sfd.FileName.EndsWith("csv"))
                {
                    return SaveDataGridToCSV(dataGridView, sfd.FileName, e, bgWorker);
                }
                else
                {
                    return SaveDataGridToExcel(dataGridView, sfd.FileName, e, bgWorker);
                }
            }
            else
            {
                return true;
            }
        }

        internal static bool SaveDataGridToCSV(DataGridView dataGridView, string fileName, DoWorkEventArgs e, BackgroundWorker bgWorker)
        {
            DataView dataView = (DataView)dataGridView.DataSource;
            double doubleRowCount = dataView.Table.Rows.Count;

            List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.Visible)
                    listVisible.Add(col);
            }

            using (StreamWriter sw = new StreamWriter(@fileName, false))
            {
                for (int j = 0; j < listVisible.Count; j++)
                {
                    if (j != listVisible.Count - 1)
                    {
                        sw.Write(((DataGridViewColumn)listVisible[j]).HeaderText + ",");
                    }
                    else
                    {
                        sw.Write(((DataGridViewColumn)listVisible[j]).HeaderText);
                        sw.WriteLine();
                    }
                }

                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < listVisible.Count; j++)
                    {
                        if (j != listVisible.Count - 1)
                        {
                            sw.Write(dataView.Table.Rows[i][((DataGridViewColumn)listVisible[j]).DataPropertyName].ToString().Trim() + ",");
                        }
                        else
                        {
                            sw.Write(dataView.Table.Rows[i][((DataGridViewColumn)listVisible[j]).DataPropertyName].ToString().Trim());
                            sw.WriteLine();
                        }
                    }

                    if (bgWorker != null && bgWorker.WorkerReportsProgress)
                    {
                        double doubleI = i;
                        double progress = ((doubleI / doubleRowCount) * 100);
                        bgWorker.ReportProgress(Convert.ToInt32(progress));
                    }
                }

            }
            return true;
        }

        internal static bool SaveDataGridToExcel(DataGridView dataGridView, string fileName, DoWorkEventArgs e, BackgroundWorker bgWorker)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            string worksheetTitle = Path.GetFileNameWithoutExtension(fileName); ;

            if (worksheetTitle == "")
            {
                worksheetTitle = "Sheet1";
            }

            using (XmlTextWriter xmlWriter = new XmlTextWriter(fileName, System.Text.Encoding.UTF8))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteProcessingInstruction("mso-application", "progid=\"Excel.Sheet\"");
                xmlWriter.WriteStartElement("Workbook", "urn:schemas-microsoft-com:office:spreadsheet");
                xmlWriter.WriteAttributeString("xmlns:o", @"urn:schemas-microsoft-com:office:office");
                xmlWriter.WriteAttributeString("xmlns:x", @"urn:schemas-microsoft-com:office:excel");
                xmlWriter.WriteAttributeString("xmlns:ss", @"urn:schemas-microsoft-com:office:spreadsheet");
                xmlWriter.WriteAttributeString("xmlns:html", @"http://www.w3.org/TR/REC-html40");

                xmlWriter.WriteStartElement("DocumentProperties", "urn:schemas-microsoft-com:office:office");
                xmlWriter.WriteStartElement("Author");
                xmlWriter.WriteString("Grand River Dam Authority");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("LastAuthor");
                xmlWriter.WriteString("Grand River Dam Authority");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Created");
                xmlWriter.WriteString(System.DateTime.Now.ToString("yyyyMMdd"));
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Company");
                xmlWriter.WriteString("Grand River Dam Authority");
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Version");
                xmlWriter.WriteString("1.00");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Styles");
                xmlWriter.WriteStartElement("Style");
                xmlWriter.WriteAttributeString("ss:ID", "s21");
                xmlWriter.WriteStartElement("Font");
                xmlWriter.WriteAttributeString("ss:Bold", "1");
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Worksheet");
                xmlWriter.WriteAttributeString("ss:Name", worksheetTitle);

                xmlWriter.WriteStartElement("Table");
                xmlWriter.WriteAttributeString("x:FullColumns", "1");
                xmlWriter.WriteAttributeString("x:FullRows", "1");
                xmlWriter.WriteAttributeString("ID", "Table1");

                for (int i = 0; i < dataGridView.ColumnCount; i++)
                {
                    if (dataGridView.Columns[i].Visible == true)
                    {
                        xmlWriter.WriteStartElement("Column");
                        xmlWriter.WriteAttributeString("ss:Width", "150");
                        xmlWriter.WriteEndElement();
                    }
                }

                //print headings
                xmlWriter.WriteStartElement("Row");
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Columns[j].Visible == true)
                    {
                        xmlWriter.WriteStartElement("Cell");
                        xmlWriter.WriteAttributeString("ss:StyleID", "s21");
                        xmlWriter.WriteStartElement("Data");
                        xmlWriter.WriteAttributeString("ss:Type", "String");
                        xmlWriter.WriteString(dataGridView.Columns[j].Name);
                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndElement();
                    }
                }
                xmlWriter.WriteEndElement();

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    xmlWriter.WriteStartElement("Row");
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        if (dataGridView.Columns[j].Visible == true)
                        {
                            xmlWriter.WriteStartElement("Cell");
                            xmlWriter.WriteStartElement("Data");
                            string type = dataGridView.Rows[i].Cells[j].GetType().ToString();
                            switch (type)
                            {
                                case "System.Decimal":
                                    xmlWriter.WriteAttributeString("ss:Type", "Number");
                                    break;
                                case "System.String":
                                default:
                                    double num;
                                    DateTime dateTime;
                                    if (double.TryParse(dataGridView.Rows[i].Cells[j].FormattedValue.ToString(), out num))
                                    {
                                        xmlWriter.WriteAttributeString("ss:Type", "Number");
                                    }
                                    else if (DateTime.TryParse(dataGridView.Rows[i].Cells[j].FormattedValue.ToString(), out dateTime))
                                    {
                                        xmlWriter.WriteAttributeString("ss:Type", "String");
                                    }
                                    else
                                    {
                                        xmlWriter.WriteAttributeString("ss:Type", "String");
                                    }
                                    break;
                            }
                            xmlWriter.WriteString(dataGridView.Rows[i].Cells[j].FormattedValue.ToString().Trim());
                            xmlWriter.WriteEndElement();
                            xmlWriter.WriteEndElement();
                        }
                    }
                    xmlWriter.WriteEndElement();

                    if (bgWorker != null && bgWorker.WorkerReportsProgress)
                    {
                        double doubleI = i;
                        double doubleRowCount = dataGridView.Rows.Count;
                        double progress = ((doubleI / doubleRowCount) * 100);
                        bgWorker.ReportProgress(Convert.ToInt32(progress));
                    }
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
                xmlWriter.Close();

                return true;
            }
        }
    }
}
