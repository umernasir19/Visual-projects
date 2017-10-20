﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    using System;
    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.DoIt();
        }
    }
    interface IBuilder
    {
        void DoIt();
    }
    class BuilderA : IBuilder
    {
        public void DoIt()
        {
            //Necessary code for building the computer type A
            Console.WriteLine("Assembly a Computer with mono monitor");
        }
    }
    class BuilderB : IBuilder
    {
        public void DoIt()
        {
            //Necessary code for building the computer type B
            Console.WriteLine("Assembly a Computer with color monitor");
        }
    }
    class MyClient
    {
        public static void Main()
        {
            Director d = new Director();
            IBuilder build = new BuilderA();
            d.Construct(build);
        }
    }
}
