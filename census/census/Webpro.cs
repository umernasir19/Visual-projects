using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace census
{
    class Webpro
    {
        SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["db"].ConnectionString);
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
        public void manipulate(string qry)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
            }
        }
        public string manipulate(string qry, string msgsuccess, string msgfailure)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = qry;
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                return msgsuccess;
            }
            catch (Exception ex)
            {
                cn.Close();
                return msgfailure;
            }
        }



        public string FindField(string qry, string fieldname)
        {
            try
            {
                da = new SqlDataAdapter(qry, cn);
                ds = new DataSet();
                da.Fill(ds, "tab");
                return ds.Tables["tab"].Rows[0][fieldname].ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
