using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        public virtual string CourseName { get; set; }
        public virtual string CourseDatetime { get; set; }
        public virtual IList<Student> StudentList { get; set; }
        public virtual Lecturer CourseLecturer { get; set; }
        public virtual IList<CourseAttendance> AttendanceList { get; set; }
        public Course()
        {
            this.StudentList = new List<Student>();
            CourseLecturer = new Lecturer();
        }

        public virtual CourseAttendance GetCourseAttendance(DateTime AttDate)
        {
            return AttendanceList.Where(s => s.AttendanceDate == AttDate).SingleOrDefault();
        }
    }
}
