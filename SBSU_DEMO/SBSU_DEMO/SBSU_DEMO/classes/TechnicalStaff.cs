using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class TechnicalStaff : _User
    {
        public virtual int TechId { get; set; }
        public TechnicalStaff()
        {
            UserType = 3;
        }
    }
}
