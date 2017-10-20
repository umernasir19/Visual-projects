using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyInformation company = new CompanyInformation();
            company.CompanyName = "ABC Company";
            company.Address = "Company Address";

            var reportA = ReportFactory.GetReport("A");
            reportA.SetCompanyInformation(company);

            var reportA1 = ReportFactory.GetReport("A");
            reportA1.SetCompanyInformation(company);

            var reportB = ReportFactory.GetReport("B");
            reportB.SetCompanyInformation(company);

            company.CompanyName = "Z Company";
        }
    }

    public interface IReport
    {
        void SetCompanyInformation(CompanyInformation company);
    }

    public class ReportA : IReport
    {
        private CompanyInformation company;

        public string ReportName { get; set; }

        public CompanyInformation CompanyInformation
        {
            get
            {
                return this.company;
            }
        }

        public void SetCompanyInformation(CompanyInformation company)
        {
            this.company = company;
        }
    }

    public class ReportB : IReport
    {
        private CompanyInformation company;

        public string ReportName { get; set; }

        public CompanyInformation CompanyInformation
        {
            get
            {
                return this.company;
            }
        }

        public void SetCompanyInformation(CompanyInformation company)
        {
            this.company = company;
        }
    }

    public class CompanyInformation
    {
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }

    public class ReportFactory
    {
        static Dictionary<string, IReport> reports = new Dictionary<string, IReport>();

        public static IReport GetReport(string key)
        {
            if (reports.Keys.Contains(key))
            {
                return reports[key];
            }
            switch (key)
            {
                case "A":
                    IReport reportA = new ReportA();
                    reports.Add(key, reportA);
                    return reportA;
                case "B":
                    IReport reportB = new ReportB();
                    reports.Add(key, reportB);
                    return reportB;

            }
            return null;
        }
    }
}
