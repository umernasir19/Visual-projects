using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace census
{
    public partial class View_citizen : Form
    {

        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public View_citizen()
        {
            InitializeComponent();
        }

        private void View_citizen_Load(object sender, EventArgs e)
        {

        }
        String qry;
        private void button1_Click(object sender, EventArgs e)
        {

            if (cnictxtbox.Text == "" || cnictxtbox.Text == null)
            {
                MessageBox.Show("enter cnic");
            }

            sqlmethods obj1 = new sqlmethods();


            qry = "select * from Publicdata  WHERE cnic='" + cnictxtbox.Text + "'";
            da = new SqlDataAdapter(qry, cn);
            ds = new DataSet();
            da.Fill(ds, "tab");
            citizenview.DataSource = ds.Tables["tab"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
