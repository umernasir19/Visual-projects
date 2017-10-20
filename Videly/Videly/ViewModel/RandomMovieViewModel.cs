using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videly.Models;

namespace Videly.ViewModel
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Costumer> costumer { get; set; }
            

    }
}