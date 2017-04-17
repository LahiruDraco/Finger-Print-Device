using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoTProject.Classes;


namespace UnitTest.IoTProject
{
    [TestClass]
    class LoadDataTest
    {
        [TestMethod]
        public void LoadBatchData()
        {
            MongoDatabase md = new MongoDatabase();
            var value =md.GetData("Batch");

            Assert.IsNotNull(value);
        }

        [TestMethod]
        public void SetBaudRateAndComport()
        {
            SerialCommunicationClass.BAUDRATE = 9600;
            SerialCommunicationClass.COMPORT = "COM";

            Assert.IsNotNull(SerialCommunicationClass.BAUDRATE);
            Assert.IsNotNull(SerialCommunicationClass.COMPORT);

        }
    }
}
