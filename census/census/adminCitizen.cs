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
    public partial class adminCitizen : Form
    {
        public adminCitizen()
        {
            InitializeComponent();
        }

        private void buttonaddcitizen_Click(object sender, EventArgs e)
        {
            addmember add = new addmember();
            add.Show();
            this.Hide();
        }

        private void buttonvieanddeltecitizen_Click(object sender, EventArgs e)
        {
            ViewCitizen vc = new ViewCitizen();
            vc.Show();
            this.Hide();
        }
    }
}
