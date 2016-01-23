using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Attendance
    {
        public virtual int Id { get; set; }
        public virtual Student student { get; set; }
        public virtual Boolean Flag { get; set; }
        public virtual CourseAttendance Course_Attendance { get; set; }
    }
}
