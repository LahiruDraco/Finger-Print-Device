using IoTProject.Database;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            ButtonManagement();
        }

        private void ButtonManagement()
        {
            if (studentDatagrid.Rows.Count == 0)
            {
                createBatchButton.Enabled = false;
                enrollFingerPrintButton.Enabled = false;
            }
        }

        private void uploadExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog.ShowDialog();
                openFileDialog.Title = "Select file";
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                string strExcelPathName;

                if (result == DialogResult.OK)
                {
                    if (openFileDialog.FileName != "")
                    {
                        strExcelPathName = openFileDialog.FileName;
                        ExtractExcelToDatagrid(strExcelPathName);
                    }
                    else
                        MessageBox.Show("Choose Excel sheet path..", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                createBatchButton.Enabled = true;
                enrollFingerPrintButton.Enabled = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            FingerPrint fingerPrintScreen = new FingerPrint(studentDatagrid);
            fingerPrintScreen.Show();
        }

        private void createBatchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(batchCode.Text))
            {
                //Extract student list from dataGrid
                ExtractStudentsFromDatagrid();

                MongoClient client = new MongoClient();
                var db = client.GetDatabase("fingerprint");

                AddStudentsToArray();

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
            else
            {
                MessageBox.Show("Cannot make fields empty");
            }
        }

        private void AddStudentsToArray()
        {
            foreach (Student item in students)
            {
                studentArray.Add(new BsonDocument{
                    {"indexNo",item.IndexNo},
                    {"firstName",item.Fname},
                    {"lastName",item.LName},
                    {"featureVector",item.FingerPrint.ToString()}
                });
            }
        }

        private void ExtractStudentsFromDatagrid()
        {
            Student st;
            foreach (DataRow dr in dtView.Rows)
            {
                st = new Student();
                string indexNumber = dr["Index No"].ToString();
                string[] indexArray = indexNumber.Split('-');


                st.IndexNo = Convert.ToInt32(indexArray[5]);
                //st.BatchCode = dr["Batch Code"].ToString();
                st.Fname = dr["First Name"].ToString();
                st.LName = dr["Last Name"].ToString();
                st.FingerPrint = dr["Feature Vector"].ToString();

                students.Add(st);

            }
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
            
            batchInfo importBatch = new batchInfo();
            importBatch.Show();

            this.Close();
        }

        public void setImportedBatchData(string id,string code,string name,string director,string student)
        {
            createBatchButton.Enabled = true;
            enrollFingerPrintButton.Enabled = true;

            batchCode.Text = code;
            batchName.Text = name;
            courseDirector.Text = director;

            //MongoClient client = new MongoClient();
            //var database = client.GetDatabase("fingerprint");
            //var collection = database.GetCollection<BsonDocument>("Batch");
            //var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            //var result = collection.Find(filter).ToListAsync();
            
            DataTable dt = new DataTable();

            List<StudentFacade> response = new List<StudentFacade>();

            response = JsonConvert.DeserializeObject<List<StudentFacade>>(student);

            //Set Datagrid forthe search result
            SetDataGrid(response, dt);

            var table = JsonConvert.DeserializeObject<DataTable>(student);
            studentDatagrid.DataSource = table;

        }

        private void SetDataGrid(List<StudentFacade> response, DataTable dt)
        {
            dt.Columns.Add("Index Number");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Feature Vector");

            List<string> indexNumbers = new List<string>();

                foreach (StudentFacade item in response)
                {
                    //string ind = batchCode.Text + "-" + item.indexNo.ToString();
                    dt.Rows.Add(item.indexNo.ToString(),item.firstName,item.lastName,item.featureVector);
                }
            studentDatagrid.DataSource = dt;
        }

        public void getFingerPrintsAndShow(DataTable dt)
        {
            studentDatagrid.Refresh();
            studentDatagrid.DataSource = dt;
        }
    }
}
