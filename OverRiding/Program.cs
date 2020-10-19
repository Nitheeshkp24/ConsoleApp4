using System;
using System.Diagnostics.CodeAnalysis;

namespace OverRiding
{

   class overr
   {
        public void Identity(string name,int id)
        {
            Console.WriteLine("Name: "+name +"      "+"id:  "+id);
        }
        public void Identity( int id, string name)
        {
            Console.WriteLine("Name: " + name + "      " + "id:  " + id);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            overr obj = new overr();
            obj.Identity("Nitheesh", 2);
            obj.Identity( 1, "Nithya");


        }
    }
}
