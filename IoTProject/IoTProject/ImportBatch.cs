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
    public partial class batchInfo : Form
    {
        //Events
        public event EventHandler SelectedRowEvent;
        string aValue, bValue, cValue;
        DataTable dt;
        
        public batchInfo()
        {
            InitializeComponent();
        }

        private void ImportBatch_Load(object sender, EventArgs e)
        {
            batchListGrid.AllowUserToAddRows = false;
            LoadBatchList();
        }

        private async void LoadBatchList()
        {
            MongoClient client = new MongoClient();

            //if (client.Cluster.Description.Servers.Single().State == ServerState.Connected)
            //{
                var database = client.GetDatabase("fingerprint");
                var collection = database.GetCollection<BsonDocument>("Batch");

                var resultList = await collection.Find(new BsonDocument()).ToListAsync();

                dt = new DataTable();


                dt.Columns.Add("Object Id");
                dt.Columns.Add("BatchCode");
                dt.Columns.Add("BatchName");
                dt.Columns.Add("CourseDirector");
                dt.Columns.Add("StudentCount");

                //Hide the object ID
                //dt.Columns[0].ColumnMapping = MappingType.Hidden;

                foreach (var item in resultList)
                {
                    dt.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString(), item[4].ToString());
                }

                batchListGrid.DataSource = dt;
            //}
            //else
            //{
            //    MessageBox.Show("Please connect the database");
                
            //}
            
        }

        private void batchListGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the selected row values
            int selectedrowindex = e.RowIndex;
            DataGridViewRow selectedRow = batchListGrid.Rows[selectedrowindex];
            var objectId = selectedRow.Cells[0].Value;
            var batchCd = selectedRow.Cells[1].Value;
            var batcNm = selectedRow.Cells[2].Value;
            var CourseDi = selectedRow.Cells[3].Value;
            var students = selectedRow.Cells[4].Value;
            

            //Trigger Event
            if (SelectedRowEvent != null)
                SelectedRowEvent(sender, e);

            //Find and pass the value to the form
            Batch batch = new Batch();
            batch.Show();
            batch.setImportedBatchData(objectId.ToString(), batchCd.ToString(), batcNm.ToString(), CourseDi.ToString(), students.ToString());
            
            this.Close();
        }

        private void freeSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = freeSearch.Text;
            dt.DefaultView.RowFilter = string.Format("BatchCode LIKE '%{0}%' OR BatchName LIKE '%{0}%' OR CourseDirector LIKE '%{0}%'", searchValue);
        }

        private void headerDataWrite_Click(object sender, EventArgs e)
        {
            string merger = aValue + "/" + bValue + "/" + cValue + "/";

            try
            {
                string path = @"c:\DATALOG.TXT";
                File.WriteAllText("DATALOG.TXT", merger);
                MessageBox.Show("File write successfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occured");
            }

        }

        private void batchListGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (batchListGrid.SelectedCells.Count > 0)
            {
                int selectedrowindex = batchListGrid.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = batchListGrid.Rows[selectedrowindex];

                aValue = selectedRow.Cells[1].Value.ToString();
                bValue = selectedRow.Cells[2].Value.ToString();
                cValue = selectedRow.Cells[3].Value.ToString();
                
            }
        }
    }
}
