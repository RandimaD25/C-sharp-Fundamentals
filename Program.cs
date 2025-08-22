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

            ////String Interpolation
            //string person_name = "Bob";
            //int person_age = 25;
            //double salary = 5000000.50;

            ////Basic interpolation
            //Console.WriteLine($"Hello, {person_name}");

            ////Expressions inside interpolation
            //Console.WriteLine($"Salary: {salary:C}"); //Currency format
            //Console.WriteLine($"Salary: {salary:F2}"); //Two decimal places

            ////Combining multiple values
            //Console.WriteLine($"{person_name} is {person_age} years old and earns {salary:C} per  year");
            //Console.ReadKey();

            ////Switch Statement
            //int dayNumber = 3;
            //switch (dayNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid day number");
            //        break;
            //}
            //Console.ReadKey();

            ////New Switch Expression
            ////int dayNum = 4;
            ////string dayType = dayNum switch
            ////{
            ////    1 => "Monday",
            ////    2 => "Tuesday",
            ////    3 => "Wednesday",
            ////    4 => "Thursday",
            ////    5 => "Friday",
            ////    6 => "Saturday",
            ////    7 => "Sunday",
            ////    _ => "Invalid day number"
            ////};

            ////Console.WriteLine(dayType);
            ////Console.ReadKey();  


            ////Ternary operation
            //int my_age = 26;
            //string message = my_age >= 18 ? "Adult" : "Minor";
            //Console.WriteLine(message);
            //Console.ReadKey();

            ////Loops
            ////Basic For Loop
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine($"Countdown: {i}");
            //}

            ////for-each Loop
            //int[] numbers = {10, 20, 30, 40, 50};
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine($"Number: {num}");
            //}

            ////While Loop
            //int count = 0;
            //while (count < 5)
            //{
            //    Console.WriteLine($"Count: {count}");
            //    count++;
            //}

            ////Do-While Loop
            //int index_num = 0;
            //do
            //{
            //    Console.WriteLine($"Do While Count: {index_num}");
            //    index_num++
            //} while (index_num < 5);


            //Methods
            //Basic Methods
            void SayHello()
            {
                Console.WriteLine("Hello Worlds");
            }

            //Method with return type
            int GetAge()
            {
                return 25;
            }

            SayHello();
            int myAge = GetAge();
            Console.WriteLine($"My age is {myAge}");


            //int sum1 = AddValue(10, 20);
            //double num1 = AddValue(10.3, 2.4);
            //string text1 = AddValue("Hello", " World");

            //Console.WriteLine(sum1, num1, text1);


            //Named Parameters
            //void CreateUser(string name, int user_age, string email)
            //{
            //    Console.WriteLine($"Create User: {name}, {user_age}, {email}");
            //}

            ////Using named arguments. this can be any order
            //CreateUser(
            //    name: "Randima",
            //    user_age: 26,
            //    email: "randima@gmail.com"
            //);

            //List
            List<string> studentNames = new List<string>
            {
                "Alice",
                "Bob",
                "Nick"
            };

            //Dictionary
            Dictionary<int, string> studentDirectory = new Dictionary<int, string>
            {
                {1, "Alice"},
                {2, "Bob"},
                {3, "Nick"}
            };

            if (studentDirectory.TryGetValue(2, out string stuName))
            {
                Console.WriteLine($"Student : {stuName}");
            } else
            {
                Console.WriteLine("Student not found");
            }

            //Get all key-value pairs
            foreach(var student in studentDirectory)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }

            //Getting all keys or values
            List<int> allKeys = studentDirectory.Keys.ToList();
            List<string> allValues = studentDirectory.Values.ToList();


            //HashSet
            HashSet<string> uniqueSubjects = new HashSet<string>
            {
                "Math",
                "Science",
                "History",
                "Geography",
                "Physics",
                "Chemistry",
            };

            //Add items using "Add" method
            bool result = uniqueSubjects.Add("English");
            Console.WriteLine(result);

            result = uniqueSubjects.Add("Math"); // Will return false since "Math" already exists
            Console.WriteLine(result);

            HashSet<string> scienceCourses = new HashSet<string>
            {
                "Physics",
                "Chemistry",
                "Biology"
            };

            //Combine sets
            uniqueSubjects.UnionWith(scienceCourses);

            foreach (var course in uniqueSubjects)
            {
                Console.WriteLine($"ForEach: {course}");
            }

            uniqueSubjects.IntersectWith(scienceCourses);

            foreach(var course in uniqueSubjects)
            {
                Console.WriteLine($"Intersected Course: {course}");
            }

















            Console.ReadKey();

        }

        //Method Overloading
        static int AddValue(int a, int b)
        {
            return a + b;
        }

        static double AddValue(double a, double b)
        {
            return a + b;
        }

        static string AddValue(string a, string b)
        {
            return a + b;
        }
    }
}
