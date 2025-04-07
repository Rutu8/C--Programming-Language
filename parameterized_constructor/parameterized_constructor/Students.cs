using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterized_constructor
{
    internal class Students
    {
        int rollno;
        string name, subject ;
        float marks;
        public Students(int rollno, string name, string subject, float marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.subject = subject;
            this.marks = marks;
        }
        public void display()
        {
            Console.WriteLine("Roll No." + rollno);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("Marks: " + marks);
        }
    }
}
