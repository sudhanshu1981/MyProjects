using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeadManager
{
    public partial class Import : Form
    {
        System.Data.DataSet DtSet;
        public Import()
        {
            InitializeComponent();
        }

        private void btn_importData_Click(object sender, EventArgs e)
        {
            // Get the DataTable 
            DataTable dtInsertRows = DtSet.Tables[0];
            string connectionString = @"Server=localhost;Database=Finaco;Trusted_Connection=true";

            // Assumes that connection is a valid SqlConnection object.  
            string queryString =
              "SELECT * FROM dbo.ImportConfiguration";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connectionString);
            DataSet ImportConfiguration = new DataSet();
            adapter.Fill(ImportConfiguration, "ImportConfiguration");

            using (SqlBulkCopy sbc = new SqlBulkCopy(connectionString))
            {
                try
                {
                    foreach (DataRow dr in ImportConfiguration.Tables["ImportConfiguration"].Rows)
                    {
                        sbc.ColumnMappings.Add(dr["SourceColumnName"].ToString(), dr["TargetColumnName"].ToString());
                    }
                    sbc.DestinationTableName = "DisbursalData";
                    sbc.BulkCopyTimeout = 8000;
                    sbc.WriteToServer(dtInsertRows);
                    sbc.Close();
                }

                catch (Exception ex)
                {

                }
            }
        }

        private void btn_loadData_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txt_selectFile.Text + ";Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\";");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                dataGridView1.DataSource = DtSet.Tables[0];
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "txt",
                Filter = "Excel files (*.xls)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_selectFile.Text = openFileDialog1.FileName;
            }

        }
    }
}
