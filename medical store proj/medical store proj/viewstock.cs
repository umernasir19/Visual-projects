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
    public partial class viewstock : Form
    {

        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["medical"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public viewstock()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String qry;
        private void viewbutton_Click(object sender, EventArgs e)
        {
            
            {
                sqlmethods obj1 = new sqlmethods();
                
                
                 qry="select * from Addstock";
                 da = new SqlDataAdapter(qry, cn);
                 ds = new DataSet();
                 da.Fill(ds, "tab");
                 showdata.DataSource = ds.Tables["tab"];
                 
                 

                
                
            }
        }
    }
}
