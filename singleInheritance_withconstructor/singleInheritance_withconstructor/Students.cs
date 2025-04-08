using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleInheritance_withconstructor
{
    
    public class Students
    {
        int rollno, marks;
        string name, subject;

        public Students()
        {
            Console.WriteLine("Enter a Roll No:");
            rollno = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a Name: ");
            name = Console.ReadLine()!;
            Console.WriteLine("Enter a Subject: ");
            subject = (Console.ReadLine()!);
            Console.WriteLine("Enter a Marks: ");
            marks = int.Parse(Console.ReadLine()!);

        }
        public void display()
        {
            Console.WriteLine("Roll No of Student: " + rollno);
            Console.WriteLine("Name of Student: " + name);
            Console.WriteLine("Subject of Student: " + subject);
            Console.WriteLine("Marks of Student: " + marks);
        }
    }
}
