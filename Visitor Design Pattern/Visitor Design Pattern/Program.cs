using System;
using System.Collections.Generic;
using System.Globalization;

namespace Earning_TaxInIndiaWithoutVisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee { EmployeeId = "XYZ1001", EmployeeName = "Banketeshvar Narayan" };
            AddDataForEmployee(emp);

            #region Calculate Net Earning of the Year
            double NetEarningoftheYear = 0.0;

            foreach (var monthlySalary_Earning in emp.MonthlySalary_Earnings)
            {
                NetEarningoftheYear += (monthlySalary_Earning.BasicSalary + monthlySalary_Earning.ConveyanceAllowance + monthlySalary_Earning.FoodCard_Bill +
                                        monthlySalary_Earning.HRAExemption + monthlySalary_Earning.MedicalAllowance + monthlySalary_Earning.OtherBills +
                                        monthlySalary_Earning.PersonalAllowance + monthlySalary_Earning.TelephoneBill);
            }

            foreach (var monthlySalary_Deduction in emp.MonthlySalary_Deductions)
            {
                NetEarningoftheYear -= (monthlySalary_Deduction.ProvidentFund_EmployeeContribution + monthlySalary_Deduction.ProvidentFund_EmployerContribution +
                                       monthlySalary_Deduction.ProfessionTax + monthlySalary_Deduction.OtherDeduction);
            }
            #endregion

            #region Calculate TaxableAmount
            double TaxableAmount = 0.0;

            foreach (var monthlySalary_Earning in emp.MonthlySalary_Earnings)
            {
                TaxableAmount += (monthlySalary_Earning.BasicSalary + monthlySalary_Earning.HRAExemption + monthlySalary_Earning.MedicalAllowance +
                                     monthlySalary_Earning.PersonalAllowance);

                //Non Taxable parts
                //monthlySalary_Earning.FoodCard_Bill 
                //monthlySalary_Earning.ConveyanceAllowance
                //monthlySalary_Earning.TelephoneBill
                //monthlySalary_Earning.OtherBills
            }

            foreach (var monthlySalary_Deduction in emp.MonthlySalary_Deductions)
            {
                TaxableAmount -= (monthlySalary_Deduction.ProvidentFund_EmployeeContribution + monthlySalary_Deduction.ProvidentFund_EmployerContribution +
                                       monthlySalary_Deduction.ProfessionTax + monthlySalary_Deduction.OtherDeduction);
            }

            foreach (var monthlyExpense in emp.MonthlyExpenses)
            {
                TaxableAmount -= monthlyExpense.MonthlyRent;
            }

            foreach (var annualInvestment in emp.AnnualInvestments)
            {
                TaxableAmount -= annualInvestment.InvestmentAmmount;
            }
            #endregion

            Console.WriteLine("Annual Net Earning Amount : {0}", NetEarningoftheYear);
            Console.WriteLine("Annual Taxable Amount : {0}", TaxableAmount);
        }

        private static void AddDataForEmployee(Employee emp)
        {
            for (int i = 1; i <= 12; i++)
            {
                emp.MonthlySalary_Earnings.Add(new MonthlySalary_Earning
                {
                    MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i),
                    BasicSalary = 120000,
                    HRAExemption = 50000,
                    ConveyanceAllowance = 1600,
                    PersonalAllowance = 45000,
                    MedicalAllowance = 1500,
                    TelephoneBill = 2500,
                    FoodCard_Bill = 3000,
                    OtherBills = 35000
                });

                emp.MonthlySalary_Deductions.Add(new MonthlySalary_Deduction
                {
                    MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(i),
                    ProvidentFund_EmployeeContribution = 8000,
                    ProvidentFund_EmployerContribution = 8000,
                    OtherDeduction = 700,
                    ProfessionTax = 200,
                    TDS = 15000
                });

                emp.MonthlyExpenses.Add(new MonthlyExpense { MonthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(1), MonthlyRent = 10000 });
            }

            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "MediclaimPolicy", InvestmentAmmount = 15000 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "MediclaimPolicyforParents", InvestmentAmmount = 25000 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "HouseLoan", InvestmentAmmount = 0.0 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "EducationLoan", InvestmentAmmount = 0.0 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "OtherInvestment", InvestmentAmmount = 5000 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "RGESS", InvestmentAmmount = 5500 });
            emp.AnnualInvestments.Add(new AnnualInvestment { InvestmentDetails = "Section80Cn80CCD_ExceptPF", InvestmentAmmount = 100000 });

            //emp.AnnualInvestments.Add(new AnnualInvestment
            //{

            //    //MediclaimPolicy = 15000,
            //    //MediclaimPolicyforParents = 25000,
            //    //HouseLoan = 0.0,
            //    //EducationLoan = 0.0,
            //    //OtherInvestment = 5000,
            //    //RGESS = 5500,
            //    //Section80Cn80CCD_ExceptPF = 100000
            //});
        }
    }

    #region Employee
    public class Employee
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public List<MonthlySalary_Earning> MonthlySalary_Earnings = new List<MonthlySalary_Earning>();
        public List<MonthlySalary_Deduction> MonthlySalary_Deductions = new List<MonthlySalary_Deduction>();
        public List<AnnualInvestment> AnnualInvestments = new List<AnnualInvestment>();
        public List<MonthlyExpense> MonthlyExpenses = new List<MonthlyExpense>();
    }
    #endregion

    #region MonthlySalary_Earning
    public class MonthlySalary_Earning
    {
        public string MonthName { get; set; }
        public double BasicSalary { get; set; }
        public double HRAExemption { get; set; }
        public double ConveyanceAllowance { get; set; }
        public double PersonalAllowance { get; set; }
        public double MedicalAllowance { get; set; }
        public double TelephoneBill { get; set; }

        public double FoodCard_Bill { get; set; }

        public double OtherBills { get; set; }
    }
    #endregion

    #region MonthlySalary_Deduction
    public class MonthlySalary_Deduction
    {
        public string MonthName { get; set; }
        public double ProvidentFund_EmployeeContribution { get; set; }
        public double ProvidentFund_EmployerContribution { get; set; }
        public double ProfessionTax { get; set; }
        public double TDS { get; set; }
        public double OtherDeduction { get; set; }
    }
    #endregion

    #region AnnualInvestment
    public class AnnualInvestment
    {
        public string InvestmentDetails { get; set; }
        public double InvestmentAmmount { get; set; }
        //public double MediclaimPolicy { get; set; }
        //public double MediclaimPolicyforParents { get; set; }
        //public double HouseLoan { get; set; }
        //public double EducationLoan { get; set; }
        //public double Section80Cn80CCD_ExceptPF { get; set; }
        //public double RGESS { get; set; }
        //public double OtherInvestment { get; set; }   
    }
    #endregion

    #region MonthlyExpense
    public class MonthlyExpense
    {
        public string MonthName { get; set; }
        public double MonthlyRent { get; set; }
    }
    #endregion
}
