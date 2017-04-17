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
    public partial class Form1 : Form
    {
        static DataSet1 ds = new DataSet1();

        DataTable dt = new DataTable();  
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createnewrow();
        }

        public void createnewrow()
        {
            if (dt.Rows.Count <= 0)
            {

                DataColumn dc1 = new DataColumn("NO", typeof(string));
                DataColumn dc2 = new DataColumn("NAME", typeof(string));


                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);



                dt.Rows.Add("Test", "Test");


                dataGridView1.DataSource = dt;
                ds.Tables.Add(dt);

            }
            else
            {

                dt.Rows.Add("Test", "Test");

                dataGridView1.DataSource = dt;


            }
        }

        public DataSet returndata()
        {
            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Print obj = new Print();
            obj.Show(); 
        }

        public void creatRowInStudent()
        {
            if (dt.Rows.Count <= 0)
            {

                DataColumn dc1 = new DataColumn("BatchCode", typeof(string));
                DataColumn dc2 = new DataColumn("BatchName", typeof(string));
                DataColumn dc3 = new DataColumn("CourseDirector", typeof(string));
                DataColumn dc4 = new DataColumn("StudentCount", typeof(string));

                dt.Columns.Add(dc1);
                dt.Columns.Add(dc2);
                dt.Columns.Add(dc3);
                dt.Columns.Add(dc4);

               

                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");

                dataGridView2.DataSource = dt;
                ds.Tables.Add(dt);

            }
            else
            {

                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");
                dt.Rows.Add("B1", "Business", "Dr Amila", "20");

                dataGridView1.DataSource = dt;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            creatRowInStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Print1 obj = new Print1();
            obj.Show(); 
        }
    }
}
