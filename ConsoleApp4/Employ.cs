using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp4
{
   public class Employ
    {
        private string name;
        private string address;
        private int age;
        private int salary;
        
        public void setName(string name)
        {
            this.name = name;

        }

        public string getName()
        {
            return name;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAge(int age)
        {
            this.age = age;

        }

        public int getAge()
        {
            return age;
        }

        public void setSalary(int salary)
        {

            this.salary = salary;

        }

        public int getSalary()
        {

            return salary;
        }
    }

}
