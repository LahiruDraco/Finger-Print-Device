﻿using System;
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
    public partial class AllReports : Form
    {
        public AllReports()
        {
            InitializeComponent();
        }

        private void batchList_Click(object sender, EventArgs e)
        {
            CrystalReport.BatchInformation bt = new CrystalReport.BatchInformation();
            bt.Show();
        }
    }
}
