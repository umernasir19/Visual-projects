using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Videly.Models;

namespace Videly.ViewModel
{
    public class AllMovie
    {
        
        public List<Movies> MovieList = new List<Movies>{
           new Movies(){Name="Movie 1"},
           new Movies(){Name="Movie2"}
           
           
       };
    }
}