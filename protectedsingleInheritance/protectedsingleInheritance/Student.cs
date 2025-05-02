using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedsingleInheritance
{
    public class Student:Person
    {
        int rollno;
        string clgname;
        public void getstudent()
        {
            getPerson();
            Console.WriteLine("Enter a roll no. ");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a college name: ");
            clgname = Console.ReadLine();
        }
        public void displaystudent()
        {
            Console.WriteLine("Roll No of Student: " + rollno);
            Console.WriteLine("College Name of the Student: " + clgname);
        }
    }
}
