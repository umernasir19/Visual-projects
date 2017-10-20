using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_OPERATION_IN_MVC.Models.ViewModel
{


    public class ViewC
    {
        SqlConnection con = new SqlConnection(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["crud"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;


        //public List<CrudOperations> getallcrud()
        //{
        //    List<CrudOperations> CRLIST = new List<CrudOperations>();
        //    try
        //    {
        //        string qry = "select * from CRUDDatabase";
        //        da = new SqlDataAdapter(qry, con);
        //        ds = new DataSet();
        //        da.Fill(ds, "tab");
                
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }


        //}
    }
}