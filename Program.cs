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
            //Console.WriteLine("Welcome to C#");


            //Console.ReadKey();

            //string firstName;
            //string lastName;
            //Console.WriteLine("Enter First Name");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Welocme Mr. \\Ms. " + firstName + " "+lastName);
            //Console.ReadKey();

            string name;
            int age;
            char grade;
            DateTime doj;
            double salary;
            Console.WriteLine("Enter Name");
            name  = Console.ReadLine();
            Console.WriteLine("Enter Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Grade");

            doj = DateTime.Parse(Console.ReadLine());
            grade = char.Parse(Console.ReadLine());
            Console.WriteLine("ENter Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: \t" + name + "\nIn Age: " + age + "\nIn Grade: \t" + grade + "\nIn Salary: \t" + salary + "\nIn Date of Joining: \t" + doj);
            Console.ReadKey();


        }
    }
}
