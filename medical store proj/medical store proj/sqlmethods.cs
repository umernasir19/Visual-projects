using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace medical_store_proj
{
    class sqlmethods
    {
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["medical"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        protected String qry;
        public bool SearchRecord(string qry)
        {
            try
            {
                da = new SqlDataAdapter(qry, cn);
                ds = new DataSet();
                da.Fill(ds, "tab");

                if (ds.Tables["tab"].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public string add(string qry, string msgsuccess, string msgfailure)
        {
            //try
            //{
                cmd = new SqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return msgsuccess;
            //}
            //catch (Exception ex)
            //{
            //    cn.Close();
            //    return msgfailure;
            //}
        }
    }
}
