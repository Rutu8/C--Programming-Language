using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedsingleInheritance
{
    public class Person
    {
        string adharno;
        string name;
        protected void getPerson()// constructor should be public
        {
            Console.WriteLine("Enter a Aadhar Number: ");
            adharno = (Console.ReadLine()!);
            Console.WriteLine("Enter a Name: ");
            name = Console.ReadLine()!;
        }
        public void displayperson()
        {
            Console.WriteLine("Aadhar Number of Person: " + adharno);
            Console.WriteLine("Name of the Person: " + name);
        }
    }
}
