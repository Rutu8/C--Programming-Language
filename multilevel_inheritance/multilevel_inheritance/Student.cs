using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class Student:Employee
    {
        int rollno;
        string subjects;
        float marks;

        public void getstudent()
        {
            Console.WriteLine("Enter a Roll Number:");
            rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Subject Name: ");
            subjects = Console.ReadLine();
            Console.WriteLine("Enter a Marks: ");
            marks = int.Parse(Console.ReadLine());  
        }
        public void displaystudent()
        {
            Console.WriteLine("Roll Number of Student: " + rollno);
            Console.WriteLine("Subject of Student: " + subjects);
            Console.WriteLine("Marks of Student: " + marks);
        }

    }
}
