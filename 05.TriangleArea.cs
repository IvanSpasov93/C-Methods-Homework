using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a method that calculates and returns the area of a triangle by given base and height

namespace _05.CalculateTriangleArea
{
    class Program
    {
        static double GetTriangleArea(double width, double height) //double for usage of real numbers
        {
            return width * height / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(width, height);  //converting the method GetTriangleArea into a variable;
            Console.WriteLine("Area of triangle is: {0}",area);
        }
    }
}
