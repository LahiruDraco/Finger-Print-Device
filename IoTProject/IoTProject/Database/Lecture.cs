using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTProject.Database
{
    public class Lecture
    {
        public string LecturerName { get; set; }
        public string LectureName { get; set; }
        public string LectureCode { get; set; }
        public int LectureWeek { get; set; }
        public DateTime LectureDate { get; set; }
        public string BatchCode { get; set; }
    }
}
