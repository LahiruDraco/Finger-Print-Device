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
using System.Management;


namespace IoTProject
{
    public partial class Form1 : Form
    {
        private SerialPort port;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort a = new SerialPort();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            //using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            //{
            //    var portnames = SerialPort.GetPortNames();
            //    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

            //    portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();
            //}


            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            // Display each port name to the console.
            foreach (string port in ports)
            {
                listView1.Items.Add(port);
            }

            //try
            //{
            //    port = new SerialPort();
            //    port.BaudRate = 9600;
            //    port.PortName = "COM7";
            //    port.Open();

            //    for (int i = 0; i < 10; i++)
            //    {
            //        label1.Text += port.ReadLine();
            //    }
                
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error");
            //}
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            port.WriteLine("ON");
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            port.WriteLine("OFF");
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void portConnect_Click(object sender, EventArgs e)
        {
            var portText = listView1.SelectedItems.ToString();

            try
            {
                port = new SerialPort();
                port.BaudRate = 9600;
                port.PortName = portText;
                port.Open();

                MessageBox.Show("Successfully connected to port {0}",portText);
                //for (int i = 0; i < 10; i++)
                //{
                //    label1.Text += port.ReadLine();
                //}

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Error");
            }
        }

        
    }
}
