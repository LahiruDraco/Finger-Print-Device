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
    public partial class Print1 : Form
    {
        public Print1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Print p = new Print();

            CrystalReport2 rpt = new CrystalReport2();
            rpt.DataSourceConnections.Clear();
            rpt.SetDatabaseLogon("1", "1", "server", "dbname", false);
            Form1 LBE = new Form1();
            DataSet ds = new DataSet();
            ds = LBE.returndata();
            rpt.SetDataSource(ds.Tables["table2"]);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh(); 
            
        }
    }
}
