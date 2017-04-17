using IoTProject.Classes;
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
    public partial class LiveStatics : Form
    {
        public LiveStatics()
        {
            InitializeComponent();
            solidGauge1.From = 0;
            solidGauge1.To = 100;
            solidGauge1.Value = SerialCommunicationClass.fingerEnrollCount;
            solidGauge1.LabelFormatter = value => value + " ";
        }
    }
}
