using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Lecturer_Catalog
    {
        public List<Lecturer> list { get; set; }
        public Lecturer_Catalog() { this.list = new List<Lecturer>(); }

        public void Add(Lecturer new_)
        {
            this.list.Add(new_);
        }
    }
}
