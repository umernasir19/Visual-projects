using CRUD_OPERATION_IN_MVC.Models;
using CRUD_OPERATION_IN_MVC.Models.ViewModel;
using CRUD_OPERATION_IN_MVC.Models.ViewModel.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_OPERATION_IN_MVC.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/
		public ActionResult Index()
		{
            CrudOperationviewmodel cr = new CrudOperationviewmodel();
            List<CrudOperations> lc = cr.getall();
			return View(lc);
		}
		

		public ActionResult Update()
		{
			return View();
		}

		public ActionResult Delete()
		{
			return View();
		}
		public ActionResult ViewR()
		{
			return View();
		}
	}
}