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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Print p = new Print();

            //CrystalReport1 rpt = new CrystalReport1();
            BatchInformationReport rpt = new BatchInformationReport();
            BatchInformation LBE = new BatchInformation();
            DataSet ds = new DataSet();
            ds = LBE.returndata();
            rpt.SetDataSource(ds.Tables["table1"]);
            this.crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();  
        }
    }
}
