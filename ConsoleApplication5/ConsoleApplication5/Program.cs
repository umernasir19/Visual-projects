using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public abstract class PlaneFactory
    {
        public abstract Productplane FactoryMethod(int type);
    }


    public class ConcreteFactory : PlaneFactory
    {
        public override Productplane FactoryMethod(int type)
        {
            switch (type)
            {
                case 1: return new Bomber();
                case 2: return new fighter();
                default: throw new ArgumentException("Invalid type.", "type");
            }
        }
    }


    public abstract class Productplane { }

    public class Bomber : Productplane { }

    public class fighter : Productplane { }
   
    class Program
    {
        static void Main(string[] args)
        {
            PlaneFactory obj = new ConcreteFactory();
            obj.FactoryMethod(1);

        }
    }
}
