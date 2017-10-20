using Mvc_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_application.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/
		public ActionResult Index()
		{
            //Blog blog1 = new Blog() { Name = "BBc", Link = "bbc.com" };
            //Blog blog2 = new Blog() { Name = "google", Link = "google.com" };

            //List<Blog> bloglist = new List<Blog>();
            //bloglist.Add(blog1);
            //bloglist.Add(blog2);




            //return View(bloglist);

            return View();
		}

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Aboutus()
        {
            return View();
        }
	}
}