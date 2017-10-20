using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace census
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminform adminform = new Adminform();
            adminform.Show();
            this.Hide();
        }

        private void buttoncitizen_Click(object sender, EventArgs e)
        {
            View_citizen viewctzn = new View_citizen();
            viewctzn.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Team team = new Team();
            team.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
