using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of coloumns for first matrix:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of rows for first matrix:");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of coloumns for second matrix:");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of rows for second matrix:");
            int r2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != c2 || r1 != r2)
            {
                Console.WriteLine("order of matrix is not same");
            }
            else
            {
                Console.WriteLine("first matrix");

                int[,] m1 = new int[r1,c1];
                for (int i = 0; i < r1; i++)
                {
                    Console.WriteLine("enter"+i+"row");
                    for (int j = 0; j < c1; j++)
                    {
                        m1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        Console.Write(m1[i, j]+" ");
                    }
                    Console.WriteLine();
                }

                int[,] m2 = new int[r2, c2];
                Console.WriteLine("second matrix");
                for (int i = 0; i < r1; i++)
                {
                    Console.WriteLine("enter" + i + "row");
                    for (int j = 0; j < c1; j++)
                    {
                        m2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        Console.Write(m2[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                int[,] r=new int[r1,c1];
                for(int i=0;i<r1;i++){
                    for(int j=0;j<c1;j++){
                        r[i,j]=0;
                     for (int k = 0; k <r1 ; k++)
                     {
                         r[i, j] +=  m1[i, k] * m2[k, j];
                     }
                    }

                }

                for (int i = 0; i < r1; i++)
                {
                    for (int j = 0; j < c1; j++)
                    {
                        Console.Write(r[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();


            }

        }
    }
}
