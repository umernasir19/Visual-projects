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
    public partial class addmember : Form
    {
        string qry;
        public addmember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Log(this.nametextbox.Text);
            bool chk = log.search(this.nametextbox.Text, "check");
            if (chk != true)
            {
                qry = "Insert into PublicData(name,cnic,province,gender) VALUES('" + nametextbox.Text + "','" + cnictextbox.Text + "','" + provincebox.Text + "','" + genderbox.Text + "')";
                String z= log.manipulate(qry, "Attained Successfull", "Some error Occur Try Again");
                MessageBox.Show(z);
                //province = ddlMemberProvince.SelectedValue;
                //education = ddlMemberEducation.SelectedValue;
                //Gender = ddlMemberGender.SelectedValue;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminCitizen ad = new adminCitizen();
            ad.Show();
            this.Hide();
        }

        
    }
}
