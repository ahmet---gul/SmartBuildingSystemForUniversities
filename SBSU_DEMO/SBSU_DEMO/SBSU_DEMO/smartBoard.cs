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
    public partial class smartBoard : Form
    {
        public int LectID;
        public smartBoard(int Lectid)
        {
            LectID = Lectid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smart Board has been started.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button2.Font = new Font(button2.Font, FontStyle.Regular);
            button1.Font = new Font(button1.Font, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smart board has been closed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Font = new Font(button1.Font, FontStyle.Regular);
            button2.Font = new Font(button2.Font, FontStyle.Bold);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerMenu menu = new LecturerMenu(LectID);
            menu.Show();
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Font = new Font(button2.Font, FontStyle.Bold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current page has been saved to the system.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
