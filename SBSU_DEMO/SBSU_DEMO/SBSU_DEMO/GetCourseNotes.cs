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
    public partial class GetCourseNotes : Form
    {
        public int StudentID;
        public GetCourseNotes(int StudID)
        {
            StudentID = StudID;
            InitializeComponent();
        }

        private void GetCourseNotes_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { "System Modeling", "22.12.2015","Download" });
            dataGridView1.Rows.Add(new object[] { "Testing", "15.12.2015", "Download" });
            dataGridView1.Rows.Add(new object[] { "Risk Management", "08.12.2015", "Download" });
            dataGridView1.Rows.Add(new object[] { "Software Process", "01.12.2015", "Download" });
            comboBox1.SelectedIndex = 1;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenu menu = new StudentMenu(StudentID);
            menu.Show();
        }
    }
}
