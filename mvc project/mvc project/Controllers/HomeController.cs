using mvc_project.Models;
using mvc_project.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_project.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/
		public ActionResult Index()
		{
			EmployeeViewModel EmployeeVm = new EmployeeViewModel();
			List<Employee> employees = EmployeeVm.GetAllemployee();
			return View(employees);
		}
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Employee employee)
		{
			EmployeeViewModel empvm = new EmployeeViewModel();
			empvm.AddEmployee(employee);

			return View();
		}
		public ActionResult Aboutus()
		{
			return View();
		}

		public ActionResult Contactus()
		{
			return View();
		}

		public ActionResult Form()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Form(double FirstNumber,double SecondNumber)
		{
			Double result = FirstNumber + SecondNumber;
			@ViewBag.Result = result;
			return View();
		}

		
	}
}