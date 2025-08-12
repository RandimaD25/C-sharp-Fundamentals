﻿using System;
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

            //Implicit type conversion
            int number = 100;
            double longNumber = number;

            //Explicit type conversion
            double price = 99.99;
            int roundedPrice = (int)price;
            String value = roundedPrice.ToString();

            Console.WriteLine(roundedPrice);
            Console.ReadKey();

            //Constants
            const double TEXT_RATE = 0.05;

            //Var keyword
            var name = "Randima";

            //Input and Output Methods

            //Basic printing
            Console.WriteLine("Hello, World!");

            //Printing variables
            string fName = "Laura";
            Console.WriteLine(fName);

            //Write vs WriteLine
            Console.Write("Hello"); // No newline

            //Print empty line
            Console.WriteLine();

            //ReadLine Method
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();

            //Getting numbers required conversion
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());



        }
    }
}
