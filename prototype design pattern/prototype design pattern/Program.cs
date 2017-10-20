using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter plane = new Fighter();
            plane.guns = "Multi shoter";
            plane.missiles = "anti tank missiles";
            plane.turbo = "yes";
            plane.weight = "1 ton";
            Console.WriteLine(plane.guns);

            //now creating prototype object//

            Fighter FighterCopy = (Fighter)plane.clone();
            FighterCopy.guns = "shoot";
            Console.WriteLine(FighterCopy.guns);
        }
    }
}
