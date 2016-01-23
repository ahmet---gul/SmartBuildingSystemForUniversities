using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBSU_DEMO
{
    public partial class StudentMenu : Form
    {
        public int StudID;
        public StudentMenu(int StudentID)
        {
            StudID = StudentID;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetCourseNotes modul1 = new GetCourseNotes(StudID);
            modul1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Weekly_Schedule modul2 = new Weekly_Schedule(StudID);
            modul2.Show();
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
            MessageBox.Show("Information About Student Menu.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
