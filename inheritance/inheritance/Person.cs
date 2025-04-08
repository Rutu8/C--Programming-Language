using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Person
    {
        string name;
        string address;
        public void getdataperson()
        {
            Console.WriteLine("Enter Your a Name: ");
            name = Console.ReadLine()!;
            Console.WriteLine("Enter Your Address: ");
            address = Console.ReadLine()!;

        }
        public void displayperson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
}
