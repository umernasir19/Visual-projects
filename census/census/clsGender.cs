using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace census
{
    class clsGender:Webpro
    {
        public void increamentGender(string Gender1, String Education)
        {
            if (Gender1 == "Male")
            {
                qry = "select * from TotalData";
                int Gender = Convert.ToInt32(FindField(qry, "Malepopulation"));
                Gender++;
                qry = "update TotalData Set malePopulation=" + Gender;
                manipulate(qry);
                if (Education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedMale"));
                    EducatedPopulation++;
                    qry = "update TotalData Set EducatedMale=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
            else
            {
                qry = "select * from TotalData";
                int Gender = Convert.ToInt32(FindField(qry, "feMalepopulation"));
                Gender++;
                qry = "update TotalData Set femalePopulation=" + Gender;
                manipulate(qry);
                if (Education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "Educatedfemale"));
                    EducatedPopulation++;
                    qry = "update TotalData Set Educatedfemale=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
        }
    }
}
