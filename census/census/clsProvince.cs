using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace census
{
    class clsProvince:Webpro
    {
        public void incrementPopulation(string province, string education)
        {
            if (province == "Sindh")
            {

                qry = "select * from TotalData";
                int ProvincePopulation = Convert.ToInt32(FindField(qry, "sindhpopulation"));
                ProvincePopulation++;
                qry = "update TotalData Set sindhpopulation=" + ProvincePopulation;
                manipulate(qry);
                if (education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "Educatedsindh"));
                    EducatedPopulation++;
                    qry = "update TotalData Set Educatedsindh=" + EducatedPopulation;
                    manipulate(qry);
                }

            }
            else if (province == "Punjab")
            {
                qry = "select * from TotalData";
                int ProvincePopulation = Convert.ToInt32(FindField(qry, "punjabpopulation"));
                ProvincePopulation++;
                qry = "update TotalData Set punjabpopulation=" + ProvincePopulation;
                manipulate(qry);
                if (education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedPunjab"));
                    EducatedPopulation++;
                    qry = "update TotalData Set Educatedpunjab=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
            else if (province == "KPK")
            {
                qry = "select * from TotalData";
                int ProvincePopulation = Convert.ToInt32(FindField(qry, "kpkpopulation"));
                ProvincePopulation++;
                qry = "update TotalData Set kpkpopulation=" + ProvincePopulation;
                manipulate(qry);
                if (education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedKPK"));
                    EducatedPopulation++;
                    qry = "update TotalData Set Educatedkpk=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
            else if (province == "Balochistan")
            {
                qry = "select * from TotalData";
                int ProvincePopulation = Convert.ToInt32(FindField(qry, "Balochistanpopulation"));
                ProvincePopulation++;
                qry = "update TotalData Set Balochistanpopulation=" + ProvincePopulation;
                manipulate(qry);
                if (education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedBalochistan"));
                    EducatedPopulation++;
                    qry = "update TotalData Set EducatedBalochistan=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
            else
            {
                qry = "select * from TotalData";
                int ProvincePopulation = Convert.ToInt32(FindField(qry, "Fatapopulation"));
                ProvincePopulation++;
                qry = "update TotalData Set Fatapopulation=" + ProvincePopulation;
                manipulate(qry);
                if (education != "NonMatric")
                {
                    qry = "select * from TotalData";
                    int EducatedPopulation = Convert.ToInt32(FindField(qry, "EducatedFata"));
                    EducatedPopulation++;
                    qry = "update TotalData Set EducatedFata=" + EducatedPopulation;
                    manipulate(qry);
                }
            }
        }
    }
}
