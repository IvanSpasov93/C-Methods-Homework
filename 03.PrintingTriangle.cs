using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a method for printing triangles as shown below:

namespace _03.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);


        }

        static void PrintLine(int start, int end) //setting start and end of printing.
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int n)
        {
            for (int line = 1; line <= n; line++) //drawing the certain line
            {
                PrintLine(1, line);
            }

            for (int line = n - 1; line >= 1; line--) //removing symbols so the triangle could be drawn.
            {
                PrintLine(1, line);
            }
        }
    }
}
