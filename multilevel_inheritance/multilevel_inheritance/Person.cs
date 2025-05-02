using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class Person
    {
        string Adharno, name;

        public void getdata()
        {
            Console.WriteLine("Enter Aadhar Number: ");
            Adharno = Console.ReadLine()!;
            Console.WriteLine("Enter a Name: ");
            name = Console.ReadLine()!;

        }

        public void displaydata()
        {
            Console.WriteLine("Aadhar Number is: " + Adharno);
            Console.WriteLine("Name is: " + name);
        }
    }
}
