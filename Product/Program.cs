using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            Console.WriteLine("Enter Product Id");
            pro.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the product name");
            pro.Name = Console.ReadLine();
            Console.WriteLine("Enter the Brand name");
            pro.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            pro.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            pro.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount");
            pro.Discount = Convert.ToInt32(Console.ReadLine());
            int Final = Convert.ToInt32(pro.disco());


            Product pro2 = new Product();
            Console.WriteLine("Enter Product Id");
            pro2.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name Of second name");
            pro2.Name = Console.ReadLine();
            Console.WriteLine("Enter the Brand name");
            pro2.BrandName = Console.ReadLine();
            Console.WriteLine("Enter Quantity");
            pro2.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            pro2.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Discount");
            pro2.Discount = Convert.ToInt32(Console.ReadLine());
            int Finals = Convert.ToInt32(pro2.disco());
            string path = Directory.GetCurrentDirectory();
            string filename = @path + "product.txt";
            using (StreamWriter write = new StreamWriter(filename))
            {

                write.WriteLine("\t\t\t\t      product Details");
                write.WriteLine("-------------------------------------------------------------------------------------------");
                write.WriteLine("ID             Product Name             Brand name             Quantity         Price           Discount           Final Price\n\n");
                write.WriteLine(pro.Id+"               "+pro.Name + "                       " + pro.BrandName + "                   " + pro.Quantity + "              " + pro.Price + "              " + pro.Discount + "              " + Final + "\n");
                write.WriteLine(pro2.Id + "               " + pro2.Name + "                      " + pro2.BrandName + "                   " + pro2.Quantity + "              " + pro2.Price + "              " + pro2.Discount + "              " + Finals );

            }
            string notepadPath = Environment.SystemDirectory + "\\notepad.exe";

            var startInfo = new ProcessStartInfo(notepadPath)
            {
                WindowStyle = ProcessWindowStyle.Maximized,
                Arguments = filename
            };

            Process.Start(startInfo);

        }
    }
}
