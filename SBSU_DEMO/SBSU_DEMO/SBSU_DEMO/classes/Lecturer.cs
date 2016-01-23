using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Lecturer : _User
    {
        public virtual IList<Course> Course_List { get; set; }
        public virtual int LecturerId { get; set; }
        public Lecturer()
        {
            this.Course_List = new List<Course>();
            UserType = 2;
        }
    }
}
