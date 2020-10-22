using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication4.Utill
{
    public class Bill
    {
        public string GenerateBill(int id1, string name, string email, int price)
        {
            Random rn = new Random();
            int no = rn.Next(1000, 2000);
            string path = Directory.GetCurrentDirectory();
            string filename = @"C:\Users\nithe\source\repos\ConsoleApp4\WebApplication4\BillReport\" + "ozreport" + no + ".txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("\t\t\t\toutput");
                writer.WriteLine("-------------------------------------------------------------------------------------------");
                writer.WriteLine("id                 Name           email            Price");
                writer.WriteLine(id1 + "                   " +name+ "              " + email + "             " + price);

            }
            return filename;
        }
    }
}