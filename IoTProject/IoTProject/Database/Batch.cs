using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Database
{
    public class Batch
    {
        public string BatchCode { get; set; }
        public string BatchName { get; set; }
        public string CourseDirector { get; set; }
        public Student[] Students { get; set; }

    }
}
