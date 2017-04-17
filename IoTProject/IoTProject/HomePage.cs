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
    public partial class HomePage : Form
    {
        SerialPort port;

        public HomePage()
        {
            InitializeComponent();
        }

        private void EnrollmentButton_Click(object sender, EventArgs e)
        {
            Batch enrollment = new Batch();
            enrollment.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool status = port.IsOpen;
            if (status)
            {
                MessageBox.Show("Device Connected to port - {0}",SerialCommunicationClass.COMPORT);
            }
            else
            {
                MessageBox.Show("Device Disconnected");
            }
            
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort();
                port.BaudRate = SerialCommunicationClass.BAUDRATE;
                port.PortName = SerialCommunicationClass.COMPORT;
                port.Open();
                toolStripStatusLabel4.Text = "Connected";
                MessageBox.Show("Successfully connected to port {0}",SerialCommunicationClass.COMPORT);
              

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error check the physical connection");
            }
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port.Close();
            toolStripStatusLabel4.Text = "Disconnected";
            MessageBox.Show("Disconnected from port ");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SerialCommunicationClass.BAUDRATE = 9600;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SerialCommunication serial = new SerialCommunication();
            serial.Show();
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            ImportData impData = new ImportData();
            impData.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.Show();
        }

        private void scanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            port.WriteLine("Xz6A");
        }
    }
}
