using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace census
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();

            
            
        }

        private void Team_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        
        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            String a;
            String b;
            a=textBox1.Text;
            b=textBox2.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "team" & textBox2.Text == "team")
            {
                Teamaddmember datainput = new Teamaddmember();
                datainput.Show();
            }
            else
            {
                MessageBox.Show("enter correct cnic and password");
            }   


            if (textBox1.Text == null || textBox2.Text == null)
            {
                MessageBox.Show("enter CNic and password");

            }
            else
            {
                Login obj = new Login(textBox1.Text, textBox2.Text);
                bool chk = obj.search("Team");

                if (chk == true)
                {
                    addmember datainput = new addmember();
                    datainput.Show();
                }
            }
        }

    }
}
