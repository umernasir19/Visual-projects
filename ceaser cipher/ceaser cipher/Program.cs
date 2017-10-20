using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceaser_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int i = 0, length;
            Console.WriteLine("enter your sentence");
            input=Console.ReadLine();
            input=input.ToLower();
            length = input.Length;
            for (i = 0; i < length; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    input[j]++;
                }
            }
        }
    }
}
