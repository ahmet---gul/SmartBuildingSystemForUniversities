using NHibernate;
using NHibernate.Linq;
using SBSU_DEMO.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBSU_DEMO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.KeyDown += new KeyEventHandler(tb_KeyDown);
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
            {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void login()
        {
            try
            {
                _User obj;
                string user_name = textBox1.Text;
                string pass = textBox2.Text;

                obj = StaticSession.session.QueryOver<_User>().Where(s => s.Email == user_name && s.Password == pass).List<_User>()[0];
                if (obj != null)
                {
                    this.Hide();
                    if (obj.UserType == 2)
                    {
                        LecturerMenu menu = new LecturerMenu(obj.LectID);
                        menu.Show();
                    }
                    else if (obj.UserType == 3)
                    {
                        TechnicalStaffMenu menu = new TechnicalStaffMenu();
                        menu.Show();
                    }
                    else if (obj.UserType == 1)
                    {
                        StudentMenu menu = new StudentMenu(obj.StudentID);
                        menu.Show();
                    }
                }
                else
                    MessageBox.Show("Hatalı şifre veya kullanıcı adı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı şifre veya kullanıcı adı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
