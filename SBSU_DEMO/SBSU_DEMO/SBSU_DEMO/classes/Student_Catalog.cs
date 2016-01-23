using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Student_Catalog
    {
        public List<Student> list { get; set; }
        public Student_Catalog() { this.list = new List<Student>(); }

        public void Add(Student new_)
        {
            this.list.Add(new_);
        }
    }
}
