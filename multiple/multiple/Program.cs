using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;

            //for (int i = 1; i <1000 ; i++)
            //{
            //    if (i % 3 == 0 || i%5==0)
            //    {
            //        a = a + i;
            //    }
            //}
            //Console.WriteLine(a);




            //double a = 0;
            //double b = 1;
            //double temp;
            //double z = 0;
            //double[] g=new double[4000000];
            
            //for (int i = 1; i <4000 ; i++)
            //{
            //    temp = a;
            //    a = b;
            //    if (a % 2 == 0)
            //    {
            //        z = a + z;
            //    }
            //    b = temp + a;

            //    Console.Write(z);
            //}
            int i=1;
            long a = 600851475143;
            long b=1, c, d;
            while (b == 0)
            {
               b= a / 2;
            }
            Console.Write(b);

        }
    }
}
