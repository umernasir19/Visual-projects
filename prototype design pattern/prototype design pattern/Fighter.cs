using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototype_design_pattern
{
    class Fighter:Planes
    {
       public string missiles;
       public  string guns;

        public void fighter(String Missile,String Guns,String Enginepower,string Weight,string Turbo)
        {
            guns = Guns;
            missiles = Missile;
            enginepower = Enginepower;
            weight = Weight;
            turbo = Turbo;


        }
        public Fighter clone()
        {
            return (Fighter)(this.MemberwiseClone());

        }
    }
}
