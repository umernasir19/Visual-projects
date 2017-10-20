using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Virtual_Interface_Pattern
{


    public abstract class Parent
    {
        public void Save()
        {
            Console.WriteLine("Creating transaction line called from parent");
            Debit();
            Console.WriteLine("Committing transaction after child method");
        }

        protected abstract void Debit();
    }


    public class Child : Parent
    {
        public string Name { get; set; }
        public decimal Credit { get; set; }

        protected override void Debit()
        {
            Console.WriteLine("Saved Child {0} with credit limit {1}", Name, Credit);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.Name = "ABC Limited";
            c.Credit = 100000;
            c.Save();
        }
    }
}
