using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBSU_DEMO.classes
{
    public class NHibernateSession
    {
        public static ISession OpenSession()
        {
            Configuration configuration;
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);

            if (path.EndsWith("SBSU_DEMO\\bin\\Debug\\"))
                path = path.Replace("bin\\Debug", "cfg");

            if (path.Contains("AttendanceTrackTest"))
            {
                path = path.Replace("AttendanceTrackTest", "SBSU_DEMO");
                path = path.Replace("bin\\Debug", "cfg");
            }

            configuration = new Configuration().Configure(Path.Combine(path, "hibernate.cfg.xml"));

            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
