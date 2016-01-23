using SBSU_Interface;
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
    public partial class TechnicalStaffMenu : Form
    {
        public TechnicalStaffMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            trackInventory inv = new trackInventory();
            inv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            trackControlResources menu = new trackControlResources();
            menu.Show();
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Information About Technical Staff Menu.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void userSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User can change his/her settings.", "User Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
