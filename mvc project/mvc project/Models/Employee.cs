using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_project.Models
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String  Mobile { get; set; }

    }
}