using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace WebApplication8.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/
		public ActionResult Index()
		{
			return View();
		}

        public ActionResult GetEmployees()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var employees = dc.Employees.OrderBy(a => a.FirstName).ToList();
                return Json[new { data = employees }, JsonRequestBehavior.AllowGet];
            }
        }
        [HttpGet]
        public ActionResult save(int id)
        {
            using ( MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var v = dc.Employees.OrderBy(a => a.EmployeeId == id).FirstOrderFault();
                return View(v);

            }
        }
        [HttpPost]
        public ActionResult save(Employee emp)
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var v = dc.Employees.OrderBy(a => a.EmployeeId == id).FirstOrderFault();
                return View(v);

            }

        }
	}
}