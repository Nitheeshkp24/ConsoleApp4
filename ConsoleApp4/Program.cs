using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employ obj = new Employ();
            Employ obj1 = new Employ();


            Console.WriteLine("\t\tEnter  1st employee details");
            Console.WriteLine("====================================================================================================================");
            Console.WriteLine("\t\tEnter  Name");
            obj.setName(Console.ReadLine());
            Console.WriteLine("\t\tEnter address");
            obj.setAddress(Console.ReadLine());
            Console.WriteLine("\t\tEnter employee age");
            obj.setAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\t\tEnter employee salary");
            
            obj.setSalary(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("==================================================================================================");

            Console.WriteLine("\t\tEnter  2nd employee details");
            Console.WriteLine("\t\tEnter  Name");
            obj1.setName(Console.ReadLine());
            Console.WriteLine("\t\tEnter address");
            obj1.setAddress(Console.ReadLine());
            Console.WriteLine("\t\tEnter employee age");
            obj1.setAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\t\tEnter employee salary");

            obj1.setSalary(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("==================================================================================================");
            Console.WriteLine("\t\toutput");
            Console.WriteLine("\t\t-------------");
            Console.WriteLine("Name\tAge\tAddress\tsalary");
            Console.WriteLine("===================================");

            Console.Write(obj.getName()); 
            Console.Write("\t");
            Console.Write(obj.getAge());
            Console.Write("\t");
            Console.Write(obj.getAddress());
            Console.Write("\t");
            Console.WriteLine(obj.getSalary());

            Console.Write(obj1.getName());
            Console.Write("\t");
            Console.Write(obj1.getAge());
            Console.Write("\t");
            Console.Write(obj1.getAddress());
            Console.Write("\t");
            Console.Write(obj1.getSalary());



        }
    }
}
