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
    public partial class shareNotes : Form
    {
        public int LectID;
        public shareNotes(int Lectid)
        {
            LectID = Lectid;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File is uploaded succesfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerMenu menu = new LecturerMenu(LectID);
            menu.Show();
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
