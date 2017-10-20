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
    public partial class CitizenAdmin : Form
    {
        public CitizenAdmin()
        {
            InitializeComponent();
        }

        private void buttonAddCitizen_Click(object sender, EventArgs e)
        {
            addmember add = new addmember();
            add.Show();
            this.Hide();
        }

        private void buttonViewCitizen_Click(object sender, EventArgs e)
        {
            ViewCitizen viewcitizen = new ViewCitizen();
            viewcitizen.Show();
            this.Hide();
        }
    }
}
