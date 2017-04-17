using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject.CrystalReport
{
    public partial class ExamEligibility : Form
    {
        DataTable dtView;

        public ExamEligibility()
        {
            InitializeComponent();
        }

        private void select_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result =  openFileDialog1.ShowDialog();
                openFileDialog1.Title = "Select file";
                openFileDialog1.InitialDirectory = @"c:\";
                openFileDialog1.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openFileDialog1.Multiselect = true;
                //openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;
                

                string strExcelPathName;

                if (result == DialogResult.OK)
                {
                    if (openFileDialog1.FileName != "")
                    {
                        strExcelPathName = openFileDialog1.FileName;
                        
                        ExtractExcelToDatagrid(strExcelPathName);
                    }
                    else
                        MessageBox.Show("Choose Excel sheet path..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExtractExcelToDatagrid(string strExcelPathName)
        {
            if (System.IO.File.Exists(strExcelPathName))
            {
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='{0}';Extended Properties=Excel 12.0;", strExcelPathName);
                string query = String.Format("SELECT * from [{0}]", "Sheet1$", strExcelPathName);

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dtView = dataSet.Tables[0];
                studentDatagrid.DataSource = dtView;

            }
            else
            {
                MessageBox.Show("No File is Selected");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
