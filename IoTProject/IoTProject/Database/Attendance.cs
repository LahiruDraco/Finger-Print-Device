using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Database
{
    public class Attendance
    {
        public Lecture Lecture { get; set; }
        public Batch Batch { get; set; }
        public int Attendances { get; set; }
    }
}
