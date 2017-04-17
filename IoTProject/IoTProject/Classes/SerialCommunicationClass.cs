using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Classes
{
    public class SerialCommunicationClass
    {
        SerialPort port;

        public static int fingerEnrollCount=0;

        public static string comport;

        public static string COMPORT
        {
            get { return comport; }
            set { comport = value; }
        }

        private static int baudrate;

        public static int BAUDRATE
        {
            get { return baudrate; }
            set { baudrate = value; }
        }
        
        

        public SerialCommunicationClass()
        {
            port = new SerialPort("COM3", 9600);
            port.Open();
        }

        public void WriteToBoard(string input)
        {
            port.WriteLine(input);
        }

        public string ReadFromBoard()
        {
            string readValue = port.ReadLine();
            return readValue ;
        }

    }
}
