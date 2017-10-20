using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c,r;
            Console.WriteLine("enter number of columns for first matrix");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of rows for first matrix");
            r = Convert.ToInt32(Console.ReadLine());

            int c1, r1;
            Console.WriteLine("enter number of columns for 2nd matrix");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of rows for 2nd matrix");
            r1 = Convert.ToInt32(Console.ReadLine());



            if(c!=c1&r!=r1)
            {
                Console.WriteLine("error ! number of coloumn and rows for both matrix should be same");
            }
            else{
            int[,] array = new int[r, c];
            int[,] array1 = new int[r, c];
            int[,] array2=new int[r,c];
            Console.WriteLine("enter first matrix");
            for (int i = 0; i <= r; i++)
            {
                for (int j = 0; j <=c ; j++)
                {
                    Console.WriteLine("enter" + i + "row and" + j + "coloumn");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("your first matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }



            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("your second matrix");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write(array1[i, j] );
                }
                Console.WriteLine(" ");
            }


            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j <c ; j++)
                {
                    array2[i, j] = array[i, j] + array1[i, j];
                }
            }
            Console.WriteLine("your resultant matrix");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(array2[i, j]);
                }
                Console.WriteLine(" ");
            }

                Console.ReadLine();
        }

    }
    }
}