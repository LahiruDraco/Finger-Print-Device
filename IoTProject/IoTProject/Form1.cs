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
            port = new SerialPort("COM3", 9600);
            port.Open();
            //port.WriteLine("A");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SerialPort a = new SerialPort();
           
            //port.WriteLine("A");
            //port.Close();
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
            //port.WriteLine("ON");
            //button1.Enabled = false;
            //button2.Enabled = true;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            //port.WriteLine("OFF");
            //button2.Enabled = false;
            //button1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (port.IsOpen)
            //{
            //    port.Close();
            //}
        }

        private void portConnect_Click(object sender, EventArgs e)
        {
            var portText = listView1.SelectedItems.ToString();

            try
            {
                port = new SerialPort();
                port.BaudRate = 115200;
                port.PortName = "COM3";
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

        private void button3_Click(object sender, EventArgs e)
        {
            port.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            port.Write(value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //label4.Text = port.ReadLine();
            //port.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //SerialPort p = new SerialPort();
            //p.BaudRate = 9600;
            //p.PortName = "COM3";
            //p.Open();

            //Loop();

            //string aa =port.ReadExisting();
            //string read = port.ReadTo("\n");

            while (true)
            {
                string data = port.ReadLine();
                listView2.Items.Add(data);
            }
        }

        private async void Loop()
        {
            //await LoopAsync();
        }

        private async Task LoopAsync()
        {
            while (true)
            {
                string data = port.ReadLine();
                listView2.Items.Add(data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.WriteLine("a");
        }

        //private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        
    }
}
