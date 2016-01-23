using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class TechnicalStaff_Catalog
    {
        public List<TechnicalStaff> list { get; set; }
        public TechnicalStaff_Catalog() { this.list = new List<TechnicalStaff>(); }

        public void Add(TechnicalStaff new_staff)
        {
            this.list.Add(new_staff);
        }
    }
}
