using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace SQL_Server_Index_Manager
{
    public partial class DatabaseConnectionProperties : Form
    {
        public DatabaseConnectionProperties()
        {
            InitializeComponent();
        }

        private bool chooseDBServerOnly = false;
        public bool ChooseDBServerOnly
        {
            set { chooseDBServerOnly = value; }
        }

        private string databaseServerName;
        public string DatabaseServerName
        {
            set { databaseServerName = value; }
        }

        private SqlConnection resultingSQLConnection;
        public SqlConnection ResultingSQLConnection
        {
            get { return resultingSQLConnection; }
        }

        private void DatabaseConnectionProperties_Load(object sender, EventArgs e)
        {
            if (chooseDBServerOnly)
            {
                databaseTableGroupBox.Enabled = false;
            }

            if (!String.IsNullOrEmpty(databaseServerName))
            {
                serverNameComboBox.Text = databaseServerName;
            }
        }

        private void loadSQLServerList(bool refresh)
        {
            if (refresh)
            {
                serverNameComboBox.Items.Clear();
            }
            if (serverNameComboBox.Items.Count == 0)
            {
                System.Data.DataTable serverList = SqlDataSourceEnumerator.Instance.GetDataSources();

                for (int i = 0; i < serverList.Rows.Count; i++)
                {
                    if ((serverList.Rows[i]["InstanceName"] as string) != null)
                        serverNameComboBox.Items.Add(serverList.Rows[i]["ServerName"] + "\\" + serverList.Rows[i]["InstanceName"]);
                    else
                        serverNameComboBox.Items.Add(serverList.Rows[i]["ServerName"]);
                }
            }
        }

        SqlConnection previousSqlConnectionForDatabaseList = new SqlConnection();
        private void loadDatabaseList()
        {
            using (SqlConnection sqlConx = getCurrentConnection())
            {
                if (previousSqlConnectionForDatabaseList != sqlConx)
                {
                    databaseNameComboBox.Items.Clear();
                    try
                    {
                        sqlConx.Open();
                        DataTable tblDatabases = sqlConx.GetSchema("Databases");
                        sqlConx.Close();
                        DataView dv = tblDatabases.DefaultView;
                        dv.Sort = "database_name";
                        foreach (DataRow row in dv.ToTable().Rows)
                        {
                            databaseNameComboBox.Items.Add(row["database_name"]);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Unable to pull a list of the databases. Please ensure that the connection information is correct.");
                    }
                }
            }
        }

        private void useSQLServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            userNameLabel.Enabled = useSQLServerAuthenticationRadioButton.Checked;
            passwordLabel.Enabled = useSQLServerAuthenticationRadioButton.Checked;
            userNameTextBox.Enabled = useSQLServerAuthenticationRadioButton.Checked;
            passwordTextBox.Enabled = useSQLServerAuthenticationRadioButton.Checked;
        }

        private void databaseNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            databaseNameComboBox.Enabled = databaseNameCheckBox.Checked;
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            if (testConnection(getCurrentConnection()))
            {
                MessageBox.Show("Connection Successful");
            }
            else
            {
                MessageBox.Show("Please ensure that the connection information was entered correctly", "Unable to Connect");
            }
        }

        private bool testConnection(SqlConnection sqlConnectionToTest)
        {
            using (SqlConnection conn = new SqlConnection(sqlConnectionToTest.ConnectionString + ";Connection Timeout=6"))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    conn.Open();
                    //MessageBox.Show("Connection Successful");
                    conn.Close();
                    return true;
                }
                catch (SqlException)
                {
                    //do nothing
                }
                catch (Exception exc)
                {
                    //MessageBox.Show("Please ensure that the connection information was entered correctly", "Unable to Connect");
                    MessageBox.Show("An unknown error has occurred. Error: " + exc.Message);
                }
                finally
                {
                    conn.Close();
                }
                Cursor.Current = Cursors.Default;
            }
            return false;
        }

        private SqlConnection getCurrentConnection()
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.ApplicationName = Application.ProductName;
            //string connectionString = "";
            //"Persist Security Info=False;Integrated Security=SSPI;database=northwind;server=mySQLServer"
            if (serverNameComboBox.Text != "")
            {
                scsb.DataSource = serverNameComboBox.Text;
                //connectionString += "Data Source = " + serverNameComboBox.Text + ";";
            }

            if (databaseNameCheckBox.Checked && databaseNameComboBox.Text != "")
            {
                scsb.InitialCatalog = databaseNameComboBox.Text;
                //connectionString += "Initial Catalog = " + databaseNameComboBox.Text + ";";
            }

            if (useWindowsAuthenticationRadioButton.Checked)
            {
                scsb.IntegratedSecurity = true;
                //connectionString += "Integrated Security=SSPI;";
            }
            else
            {
                scsb.UserID = userNameTextBox.Text;
                scsb.Password = passwordTextBox.Text;
                //connectionString += "User ID=" + userNameTextBox.Text + ";Password=" + passwordTextBox.Text + ";";
            }

            return new SqlConnection(scsb.ConnectionString);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (chooseDBServerOnly || (!chooseDBServerOnly && databaseNameCheckBox.Checked || databaseNameComboBox.Text != ""))
            {
                SqlConnection tempSqlConnection = getCurrentConnection();
                if (testConnection(tempSqlConnection))
                {
                    resultingSQLConnection = tempSqlConnection;
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("Unable to connect, would you like to use this connection anyways?", "Unable to Connect", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        resultingSQLConnection = tempSqlConnection;
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please make sure that a database is selected.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void serverNameComboBox_DropDown(object sender, EventArgs e)
        {
            loadSQLServerList(false);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            loadSQLServerList(true);
        }

        private void databaseNameComboBox_DropDown(object sender, EventArgs e)
        {
            loadDatabaseList();
        }
    }
}
