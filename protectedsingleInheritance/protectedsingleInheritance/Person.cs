using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedsingleInheritance
{
    public class Person
    {
        int adharno;
        string name;
        protected Person()
        {
            Console.WriteLine("Enter a Adhar Number: ");
            adharno = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a Name: ");
            name = Console.ReadLine()!;
        }
        public void displayperson()
        {
            Console.WriteLine("Adhar Number of Person: " + adharno);
            Console.WriteLine("Name of the Person: " + name);
        }
    }
}
