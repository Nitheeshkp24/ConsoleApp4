using System;
using System.IO;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp1 = new Employee();
            Console.WriteLine("First employee details");
            Console.WriteLine("Enter first name");
            emp1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            emp1.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee id");
            emp1.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            emp1.EmailId = Console.ReadLine();


            Employee emp2 = new Employee();
            Console.WriteLine("2nd  employee details");
            Console.WriteLine("Enter first name");
            emp2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            emp2.LastName = Console.ReadLine();
            Console.WriteLine("Enter Employee id");
            emp2.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email id");
            emp2.EmailId = Console.ReadLine();
            string fileName = @"C:\output\sample.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {

                writer.WriteLine("\t\t\t\t      output");
                writer.WriteLine("-------------------------------------------------------------------------------------------");
                writer.WriteLine("id             First name             lastname         Email\n\n");
                writer.WriteLine(emp1.EmpId + "                " + emp1.FirstName + "                " + emp1.LastName + "            " + emp1.EmailId + "\n");
                writer.WriteLine(emp2.EmpId + "                " + emp2.FirstName + "                " + emp2.LastName + "            " + emp2.EmailId);

            }
        }
    }
}
