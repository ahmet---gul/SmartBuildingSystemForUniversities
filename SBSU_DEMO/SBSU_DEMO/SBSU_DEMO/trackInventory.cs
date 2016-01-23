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
    public partial class trackInventory : Form
    {
        public trackInventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicalStaffMenu menu = new TechnicalStaffMenu();
            menu.Show();
        }

        private void trackInventory_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { "Water", "10 lt." });
            dataGridView1.Rows.Add(new object[] { "Glass pipe", "2 pc." });
            dataGridView1.Rows.Add(new object[] { "Test tubes - 50 cl.", "4 pc." });
            dataGridView1.Rows.Add(new object[] { "Acetylene ", "2 lt." });
            dataGridView1.Rows.Add(new object[] { "Alcohol burner", "150 ml." });
            dataGridView1.Rows[4].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            listBox1.SelectedIndex = 1;
        }
    }
}
