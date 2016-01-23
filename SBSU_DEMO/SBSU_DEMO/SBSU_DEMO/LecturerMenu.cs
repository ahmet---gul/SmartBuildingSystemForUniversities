using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBSU_DEMO.classes;
using NHibernate;
using SBSU_Interface;

namespace SBSU_DEMO
{
    public partial class LecturerMenu : Form
    {
        public int LectID;
        public LecturerMenu(int Lectid)
        {
            LectID = Lectid;
            InitializeComponent();
            //ıdden hocayı çek


            //label3.Text += "\r\nHoşgeldiniz " + user.Name + " " + user.Surname;
        }

        private void buttonOpenAttandance_Click(object sender, EventArgs e)
        {
            this.Hide();
            AttendenceTrackModule yoklamaMenu = new AttendenceTrackModule(LectID);
            yoklamaMenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            projectionModule modul = new projectionModule(LectID);
            modul.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            smartBoard modul = new smartBoard(LectID);
            modul.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            shareNotes modul = new shareNotes(LectID);
            modul.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information About Lecturer Menu.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User can change his/her settings.", "User Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
