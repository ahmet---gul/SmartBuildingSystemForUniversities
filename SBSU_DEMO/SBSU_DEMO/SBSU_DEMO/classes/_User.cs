using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class _User
    {
        public _User() {}
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string FingerPrint { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual int UserType { get; set; } //1 student 2 lecturer 3 technical staff
        public virtual int StudentID { get; set; }
        public virtual int LectID { get; set; } 
        public virtual int TechID { get; set; } 
    }
}
