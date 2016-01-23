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
    public partial class trackControlResources : Form
    {
        public trackControlResources()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TechnicalStaffMenu menu = new TechnicalStaffMenu();
            menu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

        private void trackControlResources_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new object[] { "Projector", "Invalid" });
            dataGridView1.Rows.Add(new object[] { "Air Conditioning", "Valid" });
            dataGridView1.Rows.Add(new object[] { "Heating", "Valid" });
            dataGridView1.Rows.Add(new object[] { "Lighting", "Valid" });
            dataGridView1.Rows.Add(new object[] { "Fire Alarm", "Valid" });
            dataGridView1.Rows.Add(new object[] { "Doors", "Valid" });
            listBox1.SelectedIndex = 2;
        }
    }
}
