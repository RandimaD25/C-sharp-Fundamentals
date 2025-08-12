using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            //Implicit type conversion
            int number = 100;
            double longNumber = number;

            //Explicit type conversion
            double price = 99.99;
            int roundedPrice = (int)price;

            Console.WriteLine(roundedPrice);
            Console.ReadKey();

        }
    }
}
