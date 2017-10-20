using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace census
{
    class Login:Webpro
    {
        public String Cnic, pass;
        public bool chk;

         public Login(String cnic,String pass)
         {
             this.Cnic = cnic;
             this.pass = pass;
            }
         public Login() { }
        public Login(string cnic)
        {
            this.Cnic = cnic;
        }
        public void Log(String cn)
        {
            this.Cnic = cn;
        }
        public bool search(string table)
        {
            string qry = "select * from " + table + " where Cnic= '" + Cnic + "' and  password = '" + pass + "'";
            this.chk = SearchRecord(qry);
            return chk;
        }

        
        public bool search(string cnic, string cheak)
        {
            string qry = "select * from PublicData where cnic= '" + Cnic + "'";
            this.chk = SearchRecord(qry);
            return chk;
        }
    }
   
}
