using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace census
{
    public partial class ViewCitizen : Form
    {
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;

        public ViewCitizen()
        {
            InitializeComponent();
        }

        private void ViewCitizen_Load(object sender, EventArgs e)
        {

        }
        String qry;
        private void Viewdata_Click(object sender, EventArgs e)
        {
            sqlmethods obj1 = new sqlmethods();


            qry = "select * from Publicdata";
            da = new SqlDataAdapter(qry, cn);
            ds = new DataSet();
            da.Fill(ds, "tab");
            showdata.DataSource = ds.Tables["tab"];
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            sqlmethods obj = new sqlmethods();
            qry = "DELETE from PublicData WHERE cnic='" + textBoxtodeletecnic.Text + "'";
            string message = obj.add(qry, "Attained Successfull", "Some error Occur Try Again");
            MessageBox.Show(message);
        }

        private void showdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminCitizen ad = new adminCitizen();
            ad.Show();
            this.Hide();
        }
    }
}
