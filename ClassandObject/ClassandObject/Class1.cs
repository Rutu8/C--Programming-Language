using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    public class Class1
    {
        int rollno;
        string name;

        public void getData()
        {
            Console.WriteLine("Enter Roll No: ");
            rollno = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a Name: ");
            name = (Console.ReadLine()!);
        }
        public void display()
        {
            Console.WriteLine("Roll Number is: " + rollno);
            Console.WriteLine("Name is: " + name);

        }

    }
}
