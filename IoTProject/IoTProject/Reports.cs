using IoTProject.Classes;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LiveStatics stats = new LiveStatics();
            stats.Show();
        }

        private void GetFeatureVector_Click(object sender, EventArgs e)
        {
            //CrystalReport.Form1 form = new CrystalReport.Form1();
            //form.Show();

            AllReports rpt = new AllReports();
            rpt.Show();
        }


        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
