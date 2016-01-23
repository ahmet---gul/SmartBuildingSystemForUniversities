using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class CourseAttendance
    {
        public virtual DateTime AttendanceDate { get; set; }
        public virtual int CourseAttendanceID { get; set; }
        public virtual IList<Attendance> AttendanceList { get; set; }
        public virtual Course RelatedCourse { get; set; }

        public CourseAttendance()
        {
            AttendanceList = new List<Attendance>();
            AttendanceDate = DateTime.Now;
        }
    }
}
