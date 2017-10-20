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
    public partial class Teamaddmember : Form
    {
        public Teamaddmember()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        String qry;
        private void button2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Log(this.textboxname.Text);
            bool chk = log.search(this.textboxname.Text, "check");
            if (chk != true)
            {
                qry = "Insert into PublicData(name,cnic,province,gender) VALUES('" + textboxname.Text + "','" + textBoxcnic.Text + "','" + textBoxprovince.Text + "','" + textBoxgender.Text + "')";
                String z = log.manipulate(qry, "Attained Successfull", "Some error Occur Try Again");
                MessageBox.Show(z);
            }
        }
    }
}
