using NHibernate;
using SBSU_DEMO.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBSU_DEMO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StaticSession.session = NHibernateSession.OpenSession();
            Application.Run(new Login());
            StaticSession.session.Close();
        }
    }
}
