using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModel;

namespace Videly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie

        public ActionResult GetMovies()
        {
           
             
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movies() { Name = "Shrek" };
            var Costumers=new List<Costumer>
            {
                new Costumer(){Name="Costumer 1"},
                new Costumer(){Name="Costumer 2"}

            };

            var viewModel=new RandomMovieViewModel()
            {
                Movie=movie,
                costumer=Costumers
                
            };
            return View(viewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{4})}")]
        public ActionResult ByReleaseYear(int year,int month)
        {
            return Content(year+"/"+month);
        }
    }
}