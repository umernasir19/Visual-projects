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
using System.Data.SqlClient;

namespace medical_store_proj
{
    public partial class addstock : Form
    {
        public addstock()
        {
            InitializeComponent();

        }
        public String qry;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textboxitemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (textboxitemname.Text == null && textBoxquantity == null && textboxprice.Text == null)
            {
                MessageBox.Show("enter all values");

            }
            else
            {
                sqlmethods obj1=new sqlmethods();
                qry = "insert into Addstock(Itemname,price,quantity,Name) values('" + textboxitemname.Text + "','" + textboxprice.Text + "','" + textBoxquantity.Text + "','" + textboxitemname.Text + "')";
                   String message = obj1.add(qry, "This member add Sucessfully", "Some error Occur Try Again");
                MessageBox.Show(message);
            }
        }
    }
}
