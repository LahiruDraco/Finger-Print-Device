using IoTProject.Database;
using MongoDB.Bson;
using MongoDB.Driver;
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

namespace IoTProject
{
    public partial class Batch : Form
    {
        List<Student> students = new List<Student>();
        BsonArray studentArray = new BsonArray();
        DataTable dtView;

        public Batch()
        {
            InitializeComponent();
        }
        
        private void uploadExcel_Click(object sender, EventArgs e)
        {
            try{
            DialogResult result = openFileDialog.ShowDialog();
            openFileDialog.Title = "Select file";
            openFileDialog.InitialDirectory = @"c:\";
            openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            string strExcelPathName;

            if (result==DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                { 
                    strExcelPathName = openFileDialog.FileName;
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

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dtView = dataSet.Tables[0];
                studentDatagrid.DataSource = dtView;
            }
            else
            {
                MessageBox.Show("No File is Selected");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FingerPrint fingerPrintScreen = new FingerPrint();
            fingerPrintScreen.Show();
        }

        private void createBatchButton_Click(object sender, EventArgs e)
        {
            //Extract student list from dataGrid
            Student st=new Student();
            foreach (DataRow dr in dtView.Rows)
            {
                st.IndexNo = int.Parse(dr["Index No"].ToString());
                st.BatchCode = dr["Batch Code"].ToString();
                st.Fname = dr["First Name"].ToString();
                st.LName = dr["Last Name"].ToString();
                st.FingerPrint = dr["Feature Vector"].ToString();

                students.Add(st);
                
            }
            ///////////////////

            MongoClient client = new MongoClient();
            var db = client.GetDatabase("fingerprint");
            //var collection = db.GetCollection<Batch>("Batch");
            //Batch batch = new Batch();
            //batch.Name = "UGC MIS";
            //collection.InsertOne(batch);

            
            Batch batch = new Batch();

            foreach (Student item in students)
            {
                studentArray.Add(new BsonDocument{
                    {"indexNo",item.IndexNo},
                    {"firstName",item.Fname},
                    {"lastName",item.LName},
                    {"featureVector",item.FingerPrint.ToString()}
                });
            }

            var document = new BsonDocument
            {
                { "batchCode" , batchCode.Text},
                { "batchName", batchName.Text },
                { "courseDirector", courseDirector.Text },
                { "students", studentArray }
            };

            var collection = db.GetCollection<BsonDocument>("Batch");
            collection.InsertOneAsync(document);
            MessageBox.Show("Data Added");

            ResetVariableData();
        }

        private void ResetVariableData()
        {
            students.Clear();
            batchCode.Clear();
            batchName.Clear();
            courseDirector.Clear();
            studentArray.Clear();
            
        }

        private void importBatchButton_Click(object sender, EventArgs e)
        {
            ImportBatch importBatch = new ImportBatch();
            importBatch.Show();
        }

    }
}
