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
            //Console.WriteLine("Hello, World!");

            ////Implicit type conversion
            //int number = 100;
            //double longNumber = number;

            ////Explicit type conversion
            //double price = 99.99;
            //int roundedPrice = (int)price;
            //String value = roundedPrice.ToString();

            //Console.WriteLine(roundedPrice);
            //Console.ReadKey();

            ////Constants
            //const double TEXT_RATE = 0.05;

            ////Var keyword
            //var name = "Randima";

            ////Input and Output Methods

            ////Basic printing
            //Console.WriteLine("Hello, World!");

            ////Printing variables
            //string fName = "Laura";
            //Console.WriteLine(fName);

            ////Write vs WriteLine
            //Console.Write("Hello"); // No newline

            ////Print empty line
            //Console.WriteLine();

            ////ReadLine Method
            //Console.Write("Enter your name: ");
            //string username = Console.ReadLine();

            ////Getting numbers required conversion
            //Console.Write("Enter your age: ");
            //int userAge = int.Parse(Console.ReadLine());

            ////String formatting
            //string fullName = "Alice";
            //int age = 30;
            //double height = 5.6;

            ////Basic string formatting
            //Console.WriteLine("Name: {0}, Age: {1}", fullName, age);
            //Console.ReadKey();

            ////Multiple placeholders
            //Console.WriteLine("{0} is {1} years old and {2} feet tall", fullName, age, height);
            //Console.ReadKey();

            ////Number formatting
            //double priceValue = 19.99;
            //Console.WriteLine("Price: {0:C}", priceValue); // Currency format
            //Console.WriteLine("Price: {0:F1}", priceValue); //One decimal: 20.0
            //Console.ReadKey();

            //String Interpolation
            string person_name = "Bob";
            int person_age = 25;
            double salary = 5000000.50;

            //Basic interpolation
            Console.WriteLine($"Hello, {person_name}");

            //Expressions inside interpolation
            Console.WriteLine($"Salary: {salary:C}"); //Currency format
            Console.WriteLine($"Salary: {salary:F2}"); //Two decimal places

            //Combining multiple values
            Console.WriteLine($"{person_name} is {person_age} years old and earns {salary:C} per  year");
            Console.ReadKey();
        }
    }
}
