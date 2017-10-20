using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class vehicle
    {
        private string wheels, brakes, steering;

        
        public string Wheels
        {
            get
            {
                return wheels;
            }
            set
            {
                wheels = value;
            }
        }

        public string name()
        {
            return this.wheels;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            vehicle vehicle = new vehicle();
            vehicle.Wheels = Convert.ToString(Console.ReadLine());
            Console.WriteLine(vehicle.name());
        }
    }
}
