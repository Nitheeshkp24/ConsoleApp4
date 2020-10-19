using Microsoft.VisualBasic;
using System;
using System.Dynamic;

namespace Area
{
    public class Area
    {
        public int h;
        public int b;
        public int o;
    }
    public class Triangle : Area
    {
        public void Triarea()
        {
            Console.WriteLine("enter the height and breadth");
            h = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int o = (h * b) / 2;
            Console.WriteLine("Area of triangle=  " + o);
        }
        public class Rectangle : Area
        {
            public void Rectarea()
            {
                Console.WriteLine("enter the height and breadth");
                h = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                int o = (h * b);
                Console.WriteLine("Area of the rectangle=  " + o);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
              
                Triangle tri = new Triangle();
               
                tri.Triarea();

                Rectangle re = new Rectangle();
               
                re.Rectarea();
            }
        }
    }
}