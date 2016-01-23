using SBSU_DEMO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SBSU_Interface
{
    public partial class projectionModule : Form
    {
        public int LectId;
        public projectionModule(int Lectid)
        {
            LectId = Lectid;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projection has been activated.","", MessageBoxButtons.OK,MessageBoxIcon.Information);
            button2.Font = new Font(button2.Font, FontStyle.Regular);
            button1.Font = new Font(button1.Font, FontStyle.Bold);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Projection has been deactivated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Font = new Font(button1.Font, FontStyle.Regular);
            button2.Font = new Font(button2.Font, FontStyle.Bold);

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerMenu menu = new LecturerMenu(LectId);
            menu.Show();
        }
    }
}
