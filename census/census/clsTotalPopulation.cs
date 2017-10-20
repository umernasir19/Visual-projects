using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace census
{
    class clsTotalPopulation:Webpro
    {
        public void TotalPopulation(String Education)
        {
            qry = "select * from TotalData"; //pakistabpopulation
            int CountryPopulation = Convert.ToInt32(FindField(qry, "Countrypopulation"));
            CountryPopulation++;
            qry = "update TotalData Set Countrypopulation=" + CountryPopulation;
            manipulate(qry);
            //provincepopulation
            if (Education == "NonMatric")
            {
                qry = "select * from TotalData";
                int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedCountry"));
                EducatedPopulation++;
                qry = "update TotalData Set EducatedCountry=" + EducatedPopulation;
                manipulate(qry);
            }

        }
    }
}
