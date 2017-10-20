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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void buttonGoforCitizen_Click(object sender, EventArgs e)
        {
            CitizenAdmin ctznadmn = new CitizenAdmin();
            ctznadmn.Show();
            this.Hide();
        }

        private void buttongototeam_Click(object sender, EventArgs e)
        {
            adminCitizen ta = new adminCitizen();
            ta.Show();
        }
    }
}
