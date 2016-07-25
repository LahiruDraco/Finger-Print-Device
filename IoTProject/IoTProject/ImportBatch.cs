using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject
{
    public partial class ImportBatch : Form
    {
        public ImportBatch()
        {
            InitializeComponent();
        }

        private void ImportBatch_Load(object sender, EventArgs e)
        {
            LoadBatchList();
        }

        private async void LoadBatchList()
        {
            MongoClient client = new MongoClient();
            var database = client.GetDatabase("fingerprint");
            var collection = database.GetCollection<BsonDocument>("Batch");

            var resultList = await collection.Find(new BsonDocument()).ToListAsync();

            var t = resultList.ToList();

            DataTable dt = new DataTable();

            dt.Columns.Add("Batch Code");
            dt.Columns.Add("Batch Name");
            dt.Columns.Add("Course Director");

            

            foreach (var item in resultList)
            {
                dt.Rows.Add(item[1].ToString(), item[2].ToString(), item[3].ToString());
            }

            batchListGrid.DataSource = dt;
        }

        private void batchListGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Close();
        }
    }
}
