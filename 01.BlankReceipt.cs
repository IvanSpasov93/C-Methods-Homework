using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a method that prints a blank cash receipt. The method should invoke three other methods:
//one for printing the header, one for the body and one for the footer of the receipt. 

namespace _01.BlankReceipt
{
    class Program
    {
        static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------ \n © SoftUni");
        }

        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }
    }
}
