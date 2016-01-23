using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Student : _User
    {
        public virtual IList<Course> CourseList { get; set; }
        public virtual int StudentId { get; set; }
        public Student()
        {
            this.CourseList = new List<Course>();
        }
    }
}
