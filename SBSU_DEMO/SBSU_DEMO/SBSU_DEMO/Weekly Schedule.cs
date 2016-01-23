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
    public partial class Weekly_Schedule : Form
    {
        public int StudentID;
        public Weekly_Schedule(int StudID)
        {
            StudentID = StudID;
            InitializeComponent();
        }

        private void Weekly_Schedule_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { "9.30 - 12.30 ","","SoftwareEngineering","","Web Services" });
            dataGridView1.Rows.Add(new object[] { "13.15 - 15.15 ","Algoritma ve Programlama"  });
            dataGridView1.Rows.Add(new object[] { "15.30 - 17.30 ", });
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentMenu menu = new StudentMenu(StudentID);
            menu.Show();
        }
    }
}
