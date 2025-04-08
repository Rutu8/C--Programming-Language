using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleInheritance_withconstructor
{
    
    public class Percentage:Students
    {
        int total_marks, percentage, marks;

        public Percentage()
        {
            Console.WriteLine("Enter a Total Marks for subject: ");
            total_marks = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a Percentage is: ");
            percentage = int.Parse(Console.ReadLine()!);
        }

        public void displaypercentage()
        {
            Console.WriteLine("Total Marks is: " + total_marks);
            Console.WriteLine("Percentage is: " + percentage);
        }

    }
}
