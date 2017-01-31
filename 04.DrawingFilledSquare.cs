﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Draw at the console a filled square of size n 

namespace _04.DrawingFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintHeaderRow(n);
        }

        private static void PrintMiddleRow(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("-"); 
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }

        private static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
    }
}
