﻿using System;
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
    public partial class remove : Form
    {
        string qry;
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["medical"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public remove()
        {
            InitializeComponent();
        }

        private void datagridmedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totaldatabutton_Click(object sender, EventArgs e)
        {
            sqlmethods obj1 = new sqlmethods();


            qry = "select * from Addstock";
            da = new SqlDataAdapter(qry, cn);
            ds = new DataSet();
            da.Fill(ds, "tab");
            datagridmedicine.DataSource = ds.Tables["tab"];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            sqlmethods obj = new sqlmethods();
            qry = "DELETE from Addstock WHERE Name='" + medicinetodeletetextbox.Text + "'";
            string message = obj.add(qry, "Attained Successfull", "Some error Occur Try Again");
            MessageBox.Show(message);
        }
    }
}
