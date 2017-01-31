using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a method that prints the sign of an integer number n.

namespace _02.SignOfInteger
{
    class Program
    {
        static void SignOfInteger(int n)
        {
            if(n > 0)
            {
                Console.WriteLine("The sign of the number {0} is positive.", n);
            }
            else if(n < 0)
            {
                Console.WriteLine("The sign of the number {0} is negative.",n);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.",n);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SignOfInteger(n);
        }
    }
}
