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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void buttonloginadmin_Click(object sender, EventArgs e)
        {
            if (textboxadminname.Text == "admin" && textBoxadminpassword.Text == "admin")
            {
                Admin_Home adminhome = new Admin_Home();
                adminhome.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("wrong id and password");
                
            }
        }
    }
}
