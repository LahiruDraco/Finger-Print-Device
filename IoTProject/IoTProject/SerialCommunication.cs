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
    public partial class SerialCommunication : Form
    {
        SerialPort port;
        public SerialCommunication()
        {
            InitializeComponent();
            GetAvailablePorts();

        }

        public void GetAvailablePorts() 
        {
            string[] ports = SerialPort.GetPortNames();
            portCombo.Items.AddRange(ports);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (receiveTextBox.Text.Equals(string.Empty))
            {
                receiveTextBox.Text = port.ReadLine();
            }
            else
            {
                receiveTextBox.Text = string.Empty;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort(SerialCommunicationClass.COMPORT, SerialCommunicationClass.BAUDRATE);
                port.Open();
                MessageBox.Show("Port Opened");
            }
            catch (Exception)
            {
                MessageBox.Show("Could not connect to port");
            }
            

            //while (true)
            //{
            //    textBox2.Text += port.ReadLine();
            //}
            
            //textBox2.Text += port.ReadLine();

        }

        private void test(object sender, EventArgs e)
        {
            receiveTextBox.Text += port.ReadExisting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "Mode Changed";

            //port = new SerialPort(SerialCommunicationClass.COMPORT, SerialCommunicationClass.BAUDRATE);
            //port.Open();
            receiveTextBox.Text = "";
            port.Write(sendTextBox.Text);

            //if (sendTextBox.Text == "Xz6A" || sendTextBox.Text == "A39B")
            //{
            //    System.Threading.Thread.Sleep(10000);
            //}

            //string tt = port.ReadLine();
            //receiveTextBox.Text = tt;
            
        }

        private void portCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPort = portCombo.SelectedItem.ToString();
            SerialCommunicationClass.COMPORT = selectedPort;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBaudRate = baudCombo.SelectedItem.ToString();
            SerialCommunicationClass.BAUDRATE = int.Parse(selectedBaudRate);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
                MessageBox.Show("Port Closed");
            }
            catch (Exception)
            {
                MessageBox.Show("Port cannot Close");
            }
        }
    }
}
