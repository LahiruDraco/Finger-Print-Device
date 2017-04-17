using IoTProject.Database;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Servers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject
{
    public partial class ImportData : Form
    {
        string path;

        public ImportData()
        {
            InitializeComponent();
            string path = Path.Combine(Environment.CurrentDirectory, @"NSBM");
            ListDirectory(folderTreeView, path);
        }

        private void uploadFile_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = true;
            openFileDialog.ShowDialog();

            string fileName = openFileDialog.FileName;
            try
            {
                string text = File.ReadAllText(fileName);

                string[] value = text.Split('/');
                batchCode.Text = value[0];
                batchName.Text = value[1];
                courseDirector.Text = value[2];

                DataTable dt = new DataTable();
                dt.Columns.Add("Attendance");

                for (int i = 3; i < value.Length; i++)
                {
                    dt.Rows.Add(value[i]);
                }

                studentDatagrid.DataSource = dt;
            }
            catch (Exception)
            {

            }

            // //Call the ShowDialog method to show the dialog box.
            //bool? userClickedOK = openFileDialog.ShowDialog();

            // //Process input if the user clicked OK.
            //if (userClickedOK == true)
            //{
            //     //Open the selected file to read.
            //    System.IO.Stream fileStream = openFileDialog.File.OpenRead();

            //    using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
            //    {
            //         //Read the first line from the file and write it the textbox.
            //        tbResults.Text = reader.ReadLine();
            //    }
            //    fileStream.Close();
            //}
        }

        private static TreeNode CreateDirectory(DirectoryInfo diectoryInfo)
        {
            var directoryNode = new TreeNode(diectoryInfo.Name);

            foreach (var directory in diectoryInfo.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectory(directory));
            }
            foreach (var file in diectoryInfo.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            }

            return directoryNode;
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);

            treeView.Nodes.Add(CreateDirectory(rootDirectoryInfo));
        }

        private void folderTreeView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            path = folderTreeView.SelectedNode.FullPath;
            MessageBox.Show("Folder location selected to - {0}",path);
            
        }

        private void saveStudent_Click(object sender, EventArgs e)
        {
            string fileName = path + "\\" + subject.Text + "_" + session.Text + ".xlsx";
            ExportToExcel(fileName, subject.Text , session.Text);
        }

        private void ExportToExcel(string fileName,string subject, string worksheetName)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = string.Format(subject,worksheetName);

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < indexGridView.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < indexGridView.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = indexGridView.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = indexGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;
                saveDialog.FileName = fileName;
                


                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                } 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
                studentDatagrid.DataSource = null;
                indexGridView.DataSource = null;
            }

        }

        private void detectIndexNumbers_Click(object sender, EventArgs e)
        {
            GetDatabaseValues();
        }

        private async void GetDatabaseValues()
        {
            MongoClient client = new MongoClient();
            DataTable dt = new DataTable();

            //if (client.Cluster.Description.Servers.Single().State == ServerState.Connected)
            //{
                var database = client.GetDatabase("fingerprint");
                var collection = database.GetCollection<BsonDocument>("Batch");
                var filter = Builders<BsonDocument>.Filter.Eq("batchCode", batchCode.Text);
                var resultList = await collection.Find(filter).ToListAsync();

                //MongoDatabase mongo = new MongoDatabase();
                //var resultList = mongo.GetData("Batch", "BSC-UGC-MIS-15-17");

                List<StudentFacade> response = new List<StudentFacade>();

                foreach (var item in resultList)
                {
                    string aaa = item[4].ToString();
                    response = JsonConvert.DeserializeObject<List<StudentFacade>>(item[4].ToString());   
                }

                GetMarkedAttednaceList(response,dt);

            //}
            //else
            //{
            //    MessageBox.Show("Please connect the database");

            //}
        }

        private void GetMarkedAttednaceList(List<StudentFacade> response,DataTable dt)
        {
            dt.Columns.Add("Index Number");
            List<string> indexNumbers = new List<string>();
            

            for (int i = 0; i < studentDatagrid.Rows.Count-1; i++)
            {

                string featureVector = studentDatagrid.Rows[i].Cells["Attendance"].Value.ToString();

                foreach (StudentFacade item in response)
                {
                    if (featureVector == item.featureVector)
                    {
                        string ind = batchCode.Text + "-" + item.indexNo.ToString();
                        dt.Rows.Add(ind);
                    }
                }
            }
            foreach (DataGridViewRow row in studentDatagrid.Rows)
            {
                
            }
            indexGridView.DataSource = dt;
        }
    }
}
