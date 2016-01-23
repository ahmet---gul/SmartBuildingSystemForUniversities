using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class Course_Catalog
    {
        public IList<Course> list { get; set; }
        public NHibernate.ISession session = NHibernateSession.OpenSession();

        public Course_Catalog()
        {
            this.list = session.CreateCriteria<Course>().List<Course>();
        }

        public void Add(Course new_)
        {
            this.list.Add(new_);
        }

        public IList<Course> getLecturerCourses(int lecturer_id)
        {
            return this.list.Where<Course>(x => x.CourseLecturer.LecturerId == lecturer_id).ToList();
        }
    }
}
