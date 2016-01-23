using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class CourseAttendance_Catalog
    {
        public IList<CourseAttendance> list { get; set; }
        public NHibernate.ISession session = NHibernateSession.OpenSession();

        public CourseAttendance_Catalog()
        {
            this.list = session.CreateCriteria<CourseAttendance>().List<CourseAttendance>();
        }

        public void Add(CourseAttendance new_)
        {
            this.list.Add(new_);
        }

        public IList<CourseAttendance> getCourseAttendances(int course_id)
        {
            return this.list.Where<CourseAttendance>(x => x.RelatedCourse.CourseId == course_id).ToList();
        }
    }
}
