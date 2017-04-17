using IoTProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTProject
{
    public partial class FingerPrint : Form
    {
        DataGridView studentdataGridView;
        SerialCommunicationClass serialClass;
        SerialPort port;
        int count = 0;

        public FingerPrint()
        {
            
        }

        public FingerPrint(DataGridView dataGridView)
        {
            InitializeComponent();
            this.studentdataGridView = dataGridView;
            GetFirstStudent();
            OpenConnection();
            loadIndexVsFeatureVector();
            label3.Text = "";

        }

        private void OpenConnection()
        {
            try
            {
                //port = new SerialPort("COM3", 9600);
                string com = SerialCommunicationClass.COMPORT;
                int baud = SerialCommunicationClass.BAUDRATE;
                port = new SerialPort(com,baud);
                port.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Connect you device");
            }
        }

        private void loadIndexVsFeatureVector()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IndexNo");
            dt.Columns.Add("FeatureVector");


            foreach (DataGridViewRow rows in studentdataGridView.Rows)
            {
                dt.Rows.Add(rows.Cells[0].Value,"");
            }

            featureVectorDataGrid.DataSource = dt;
            label2.Text = (count + 1).ToString();


        }

        private void GetFirstStudent()
        {
            string index= studentdataGridView.Rows[0].Cells[count].Value.ToString();
            label2.Text = index;
            //serialClass = new SerialCommunicationClass();
        }

        public void loopIndex()
        {
            foreach (DataGridViewRow  row in studentdataGridView.Rows)
            {
                //((DataGridViewCheckBoxCell)row.Cells[0]).Value = true;
                label2.Text = "test";
                row.Cells[4].Value = "aa";
            }
        }

        private void SaveFeatureVector_Click(object sender, EventArgs e)
        {
            this.progressBar.Value = 0;
            this.progressTimer.Start();
            
            port.Write("A39B");
        }

        private void SaveFeatureVector_Click_1(object sender, EventArgs e)
        {
            //label3.Text = serialClass.ReadFromBoard();
            string featureVector = port.ReadLine();
            label3.Text = featureVector;

            //Set to orginal dataset
            studentdataGridView.Rows[count].Cells[4].Value = featureVector;

            //Set to temporary datagridview
            featureVectorDataGrid.Rows[count].Cells[1].Value = featureVector;

            //Increase Finger Enrolled Count
            ++SerialCommunicationClass.fingerEnrollCount;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //if (count <= studentdataGridView.Rows.Count)
            //{
                ++count;
                label2.Text = count.ToString();
            //}
            //this.progressBar.Value = 0;
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (count!=1)
            {
                --count;
                label2.Text = count.ToString(); 
            }
            this.progressBar.Value = 0;
        }

        private void CreateDataSet_Click(object sender, EventArgs e)
        {
            //featureVectorDataGrid;

            //Batch.getFingerPrintsAndShow(featureVectorDataGrid);
            DataTable dt = new DataTable();
            DataTable data = (DataTable)(studentdataGridView.DataSource);
            Batch bt = new Batch();
            bt.getFingerPrintsAndShow(dt);
            port.Close();
            this.Close();
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(2);
        }
    }
}
