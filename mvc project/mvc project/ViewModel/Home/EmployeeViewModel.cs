using mvc_project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace mvc_project.ViewModel.Home
{
    public class EmployeeViewModel
    {
        public List<Employee> GetAllemployee()
        {
            List<Employee> employees = new List<Employee>();

            String connstring =System.Web.Configuration.WebConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn=new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("USP_EMPLOYEESGETALLEMPLOYEES", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Employee emp = new Employee();
                        emp.EmployeeId = Convert.ToInt16(reader["EmployeeId"]);
                        emp.Name = reader["Name"].ToString();
                        emp.Email = reader["Email"].ToString();
                        emp.Mobile = reader["Mobile"].ToString();

                        employees.Add(emp);
                    }



                }
            }

            return employees;
        }

      public void AddEmployee(Employee employee)
        {
            String connstring =System.Web.Configuration.WebConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                using (SqlCommand cmd = new SqlCommand("USP_EMPLOYEESGETALLEMPLOYEES", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    conn.Open();

                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);
                    cmd.Parameters.AddWithValue("@Mobile", employee.Mobile);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}