using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject.CrystalReport
{
    public partial class BatchInformation : Form
    {
        //DataSet ds;
        static DataSet2 ds = new DataSet2();
        DataTable dt = new DataTable();

        DataColumn dc1, dc2, dc3, dc4, dc5;
        public BatchInformation()
        {
            InitializeComponent();
        }

        private void BatchInformation_Load(object sender, EventArgs e)
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

            dc1 = new DataColumn("ObjectId", typeof(string));
            dc2 = new DataColumn("BatchCode", typeof(string));
            dc3 = new DataColumn("BatchName", typeof(string));
            dc4 = new DataColumn("CourseDirector", typeof(string));
            //dc5 = new DataColumn("StudentCount", typeof(string));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            //dt.Columns.Add(dc5);

            //Hide the object ID
            //dt.Columns[0].ColumnMapping = MappingType.Hidden;

            foreach (var item in resultList)
            {
                dt.Rows.Add(item[0].ToString(), item[1].ToString(), item[2].ToString(), item[3].ToString());
            }

            batchListGrid.DataSource = dt;
            ds.Tables.Add(dt);





        }

        private void freeSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = freeSearch.Text;
            dt.DefaultView.RowFilter = string.Format("BatchCode LIKE '%{0}%' OR BatchName LIKE '%{0}%' OR CourseDirector LIKE '%{0}%'", searchValue);
        }

        private void batchListGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        public DataSet returndata()
        {
            return ds;
        }

        private void print_Click(object sender, EventArgs e)
        {
            PrintBatchInfo print = new PrintBatchInfo();
            print.Show();
        }
    }
}
