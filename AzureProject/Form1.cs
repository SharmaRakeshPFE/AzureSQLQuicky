using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AzureProject
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pbar.Visible = true;
            //Create a connection calling the App.config
            //Create a connection calling the App.config

            //Enable this when we will use the App.Config
            //string conn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;


            string AzureSQL = txtServerName.Text;
            string AzureDB = "Master";
            string User = txtuser.Text;
            string pwd = txtpawd.Text;
            string connattachms = "Server = tcp:" + AzureSQL + ",1433" + ";Initial Catalog=" + AzureDB + "; Persist Security Info = False; User ID=" + User + "; Password=" + pwd + "; Encrypt=True; TrustServerCertificate=False; Connection Timeout = 30";
            string conns = connattachms;
            //MessageBox.Show(conn);
            //The query to use
            string dbquery = "SELECT upper(name) as 'Database',create_date as 'CreatedDate',collation_name as 'DB Collation' from sys.databases";
            SqlConnection connectiondbs = new SqlConnection(conns);
            //Create a Data Adapter
            SqlDataAdapter dadapterdb = new SqlDataAdapter(dbquery, connectiondbs);
            DataSet dsdb = new DataSet();
            //Open the connection
            //Fill the Data Adapter
            dadapterdb.Fill(dsdb, "Databases");
            dgvDatabases.DataSource = dsdb;
            dgvDatabases.DataMember = "Databases";
            connectiondbs.Close();





            //Using Direct Connection String
            AzureSQL = txtServerName.Text;
            AzureDB = Dbcombo.Text;
            //MessageBox.Show(AzureDB);
            User = txtuser.Text;
            pwd = txtpawd.Text;
            string connattach = "Server = tcp:" + AzureSQL + ",1433" + ";Initial Catalog=" + "master" + "; Persist Security Info = False; User ID=" + User + "; Password=" + pwd + "; Encrypt=True; TrustServerCertificate=False; Connection Timeout = 30";
            string conn = connattach;
            //MessageBox.Show(conn);
            //The query to use
            Pbar.Value = 10;
            //#######################################################################
            string query = "select top 100 upper(database_name) 'Database',upper(event_category) 'Event_Category',upper(event_type) 'Event_Type',description 'Description', End_time as 'END_TIME' from sys.event_log order by END_TIME desc";
            SqlConnection connection = new SqlConnection(conn);
            //Create a Data Adapter
            SqlDataAdapter dadapter = new SqlDataAdapter(query, connection);
            //Create the dataset
            DataSet ds = new DataSet();
            //Open the connection
            connection.Open();
            //Fill the Data Adapter
            dadapter.Fill(ds, "LoadTest");
            dgv.DataSource = ds;
            dgv.DataMember = "LoadTest";
            Pbar.Value = 20;

            //#######################################################################
            string Command = "SELECT * from [sys].firewall_rules";
            SqlDataAdapter dadapterfirewall = new SqlDataAdapter(Command, connection);
            //MessageBox.Show(Command);
            //Create the dataset
            DataSet dsfirewall = new DataSet();
            //Open the connection
            //Fill the Data Adapter
            dadapterfirewall.Fill(dsfirewall, "Firewall");
            dgvfirewall.DataSource = dsfirewall;
            dgvfirewall.DataMember = "Firewall";
            Pbar.Value = 30;
            //#######################################################################

            string CommandSession = "select session_id as SessionID,login_time as Login_Time,Host_Name,Program_Name,Host_Process_ID,Client_Interface_Name,host_process_id as Host_Process_ID,Last_Request_End_Time,Reads,Writes,Logical_Reads,Original_login_name,Database_ID from sys.dm_exec_sessions";
            SqlDataAdapter dadaptersession = new SqlDataAdapter(CommandSession, connection);
            DataSet dsSession = new DataSet();
            dadaptersession.Fill(dsSession, "Session");
            dgvSession.DataSource = dsSession;
            dgvSession.DataMember = "Session";
            Pbar.Value = 50;
            //#######################################################################

            string CommandConnections = "select Session_ID,Connect_Time,Net_Transport,Protocol_Type,Auth_Scheme,Num_Reads,Num_Writes,Last_read,Last_Write,Client_Net_Address from sys.dm_exec_connections";
            SqlDataAdapter dadapterConnections = new SqlDataAdapter(CommandConnections, connection);
            DataSet dsConnections = new DataSet();
            dadapterConnections.Fill(dsConnections, "Connections");
            dgvconnections.DataSource = dsConnections;
            dgvconnections.DataMember = "Connections";
            //#######################################################################

            System.Text.StringBuilder sbSTATS = new System.Text.StringBuilder();
            sbSTATS.AppendLine(@"SELECT upper(database_name) as 'Database_Name',avg(avg_cpu_percent) AS 'Average CPU use in percent', max(avg_cpu_percent) AS 'Maximum CPU use in percent', avg(avg_data_io_percent) AS 'Average physical data IO use in percent',");
            sbSTATS.AppendLine(@"max(avg_data_io_percent) AS 'Maximum physical data IO use in percent',avg(avg_log_write_percent) AS 'Average log write use in percent', max(avg_log_write_percent) AS 'Maximum log write use in percent',");
            sbSTATS.AppendLine(@"avg(max_session_percent) AS 'Average % of sessions', max(max_session_percent) AS 'Maximum % of sessions', avg(max_worker_percent) AS 'Average % of workers',max(max_worker_percent) AS 'Maximum % of workers'");
            sbSTATS.AppendLine(@"FROM sys.resource_stats ");
            sbSTATS.AppendLine(@"WHERE database_name =");
            sbSTATS.AppendLine(@"'" + AzureDB + "'");
            sbSTATS.AppendLine(@"AND start_time > DATEADD(day, -7, GETDATE()) group by database_name;");
            string RstatsQuery = sbSTATS.ToString();
            SqlDataAdapter dadapterstats = new SqlDataAdapter(RstatsQuery, connection);
            DataSet dsstats = new DataSet();
            dadapterstats.Fill(dsstats, "RstatsQuery");
            DgvRUsage.DataSource = dsstats;
            DgvRUsage.DataMember = "RstatsQuery";




            System.Text.StringBuilder sbSTATS12 = new System.Text.StringBuilder();
            sbSTATS12.AppendLine(@"SELECT * FROM sys.resource_stats");
            sbSTATS12.AppendLine(@"WHERE database_name =");
            sbSTATS12.AppendLine(@"'" + AzureDB + "'");
            sbSTATS12.AppendLine(@"AND start_time > DATEADD(hour, -12, GETDATE()) ORDER BY start_time DESC;");
            string Rstats12Query = sbSTATS12.ToString();
            SqlDataAdapter dadapterstats12 = new SqlDataAdapter(Rstats12Query, connection);
            DataSet dsstats12 = new DataSet();
            dadapterstats12.Fill(dsstats12, "Rstats12Query");
            dgstats.DataSource = dsstats12;
            dgstats.DataMember = "Rstats12Query";


            //################################################3
            connection.Close();
            Pbar.Value = 70;


            string connattachu = "Server = tcp:" + AzureSQL + ",1433" + ";Initial Catalog=" + AzureDB + "; Persist Security Info = False; User ID=" + User + "; Password=" + pwd + "; Encrypt=True; TrustServerCertificate=False; Connection Timeout = 30";
            string connuser = connattachu;
            //MessageBox.Show(conn);
            //The query to use
            SqlConnection connectionuser = new SqlConnection(connuser);
            //Open the connection
            connectionuser.Open();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine(@"WITH AggregatedCPU AS (SELECT q.query_hash, SUM(count_executions * avg_cpu_time / 1000.0) AS total_cpu_millisec, SUM(count_executions * avg_cpu_time / 1000.0)/ SUM(count_executions) AS avg_cpu_millisec, MAX(rs.max_cpu_time / 1000.00) AS max_cpu_millisec, MAX(max_logical_io_reads) max_logical_reads, COUNT(DISTINCT p.plan_id) AS number_of_distinct_plans, COUNT(DISTINCT p.query_id) AS number_of_distinct_query_ids, SUM(CASE WHEN rs.execution_type_desc='Aborted' THEN count_executions ELSE 0 END) AS Aborted_Execution_Count, SUM(CASE WHEN rs.execution_type_desc='Regular' THEN count_executions ELSE 0 END) AS Regular_Execution_Count, SUM(CASE WHEN rs.execution_type_desc='Exception' THEN count_executions ELSE 0 END) AS Exception_Execution_Count, SUM(count_executions) AS total_executions, MIN(qt.query_sql_text) AS sampled_query_text");
            sb.AppendLine(@"FROM sys.query_store_query_text AS qt JOIN sys.query_store_query AS q ON qt.query_text_id=q.query_text_id");
            sb.AppendLine(@"JOIN sys.query_store_plan AS p ON q.query_id=p.query_id JOIN sys.query_store_runtime_stats AS rs ON rs.plan_id=p.plan_id");
            sb.AppendLine(@"JOIN sys.query_store_runtime_stats_interval AS rsi ON rsi.runtime_stats_interval_id=rs.runtime_stats_interval_id");
            sb.AppendLine(@"WHERE rs.execution_type_desc IN ('Regular', 'Aborted', 'Exception')AND rsi.start_time>=DATEADD(HOUR, -2, GETUTCDATE())");
            sb.AppendLine(@"GROUP BY q.query_hash), OrderedCPU AS (SELECT query_hash, total_cpu_millisec, avg_cpu_millisec, max_cpu_millisec, max_logical_reads, number_of_distinct_plans, number_of_distinct_query_ids, total_executions, Aborted_Execution_Count, Regular_Execution_Count, Exception_Execution_Count, sampled_query_text, ROW_NUMBER() OVER (ORDER BY total_cpu_millisec DESC, query_hash ASC) AS RN");
            sb.AppendLine(@"FROM AggregatedCPU)SELECT OD.total_cpu_millisec, OD.avg_cpu_millisec, OD.max_cpu_millisec, OD.max_logical_reads, OD.number_of_distinct_plans, OD.number_of_distinct_query_ids, OD.total_executions, OD.Aborted_Execution_Count, OD.Regular_Execution_Count, OD.Exception_Execution_Count, OD.sampled_query_text, OD.RN");
            sb.AppendLine(@"FROM OrderedCPU AS OD WHERE OD.RN<=15 ORDER BY total_cpu_millisec DESC;");
            string TopSQLQuery = sb.ToString();
            SqlDataAdapter dadaptertopsql = new SqlDataAdapter(TopSQLQuery, connectionuser);
            DataSet dstopsql = new DataSet();
            dadaptertopsql.Fill(dstopsql, "TopSQL");
            dgvtopsql.DataSource = dstopsql;
            dgvtopsql.DataMember = "TopSQL";


            Pbar.Value = 80;
            //###################################################################
            SqlCommand MyCmd = new SqlCommand(Command, connectionuser);
            MyCmd.CommandText = ("SELECT SUM(CAST(FILEPROPERTY(name, 'SpaceUsed') AS bigint) * 8192.) / 1024 / 1024 AS DatabaseSizeInMB FROM sys.database_files WHERE type_desc = 'ROWS';");

            SqlDataReader DR1 = MyCmd.ExecuteReader();
            if (DR1.Read())
            {
                lblsize.Text = DR1.GetValue(0).ToString();
                lblsize.Text = lblsize.Text + "  MB";
            }
            DR1.Close();
            Pbar.Value = 90;
            //###################################################################

            System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
            StringBuilder.AppendLine(@"select upper(schema_name(tab.schema_id) + '.' + tab.name) as [TableName], cast(sum(spc.used_pages * 8)/1024.00 as numeric(36, 2)) as UsedMB,");
            StringBuilder.AppendLine(@"cast(sum(spc.total_pages * 8)/1024.00 as numeric(36, 2)) as AllocatedMB from sys.tables tab  inner join sys.indexes ind  on tab.object_id = ind.object_id");
            StringBuilder.AppendLine(@"inner join sys.partitions part  on ind.object_id = part.object_id and ind.index_id = part.index_id inner join sys.allocation_units spc");
            StringBuilder.AppendLine(@"on part.partition_id = spc.container_id group by schema_name(tab.schema_id) + '.' + tab.name");
            StringBuilder.AppendLine(@"order by sum(spc.used_pages) desc");
            string TblSize = StringBuilder.ToString();

            SqlDataAdapter DataAdapterTblSize = new SqlDataAdapter(TblSize, connectionuser);
            DataSet DSTblSize = new DataSet();
            DataAdapterTblSize.Fill(DSTblSize, "TblSize");
            DgTblSize.DataSource = DSTblSize;
            DgTblSize.DataMember = "TblSize";

            Pbar.Value = 100;
            MessageBox.Show("Data Loaded Successfully from Azure");

            connectionuser.Close();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            //txtServerName.Text = "rsazuresqlserver.database.windows.net";
            //txtuser.Text = "rakesh";
            //txtpawd.Text = "C0nnect@1957";
            button1.Enabled = false;
            Pbar.Visible = false;
            Pbar.Minimum = 0;
            Pbar.Maximum = 100;
          
            this.Size = new Size(700, 600);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtServerName.Text) || string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpawd.Text))
            {
                MessageBox.Show("Please Enter Required Credentials", "Missing Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            {
                string AzureSQL = txtServerName.Text;
                string AzureDB = "Master";
                string User = txtuser.Text;
                string pwd = txtpawd.Text;
                string connattach = "Server = tcp:" + AzureSQL + ",1433" + ";Initial Catalog=" + AzureDB + "; Persist Security Info = False; User ID=" + User + "; Password=" + pwd + "; Encrypt=True; TrustServerCertificate=False; Connection Timeout = 30";
                string conn = connattach;
                //MessageBox.Show(conn);
                //The query to use
                string dbquery = "SELECT name from sys.databases"; SqlConnection connection = new SqlConnection(conn);
                //Create a Data Adapter
                SqlDataAdapter dadapterdb = new SqlDataAdapter(dbquery, connection);
                //MessageBox.Show(dbquery);
                //Create the dataset
                DataSet dsdb = new DataSet();
                //Open the connection
                //Fill the Data Adapter
                dadapterdb.Fill(dsdb, "Databases");
                Dbcombo.DisplayMember = "Name";
                Dbcombo.ValueMember = "Name";
                Dbcombo.DataSource = dsdb.Tables["Databases"];

                // dgvDatabases.DataSource = dsdb.Tables["Databases"];
               
                
                             connection.Close();
                button1.Enabled = true;

            }
        }




       






    }
}
