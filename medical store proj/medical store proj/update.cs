using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_store_proj
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }
        string qry;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textboxname == null || textBoxprice == null || textboxquantity == null)
            {
                MessageBox.Show("enter values in all fields");
            }
            else
            {
                sqlmethods obj = new sqlmethods();
               qry= "UPDATE Addstock SET Itemname = '" + textboxname.Text + "',price='" + textBoxprice.Text + "',quantity='" + textboxquantity.Text + "' WHERE Name='" +textboxname.Text+ "'";
               String mesage=obj.add(qry, "success", "failed");
               MessageBox.Show(mesage);
            }
        }
    }
}
