using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    internal class Average
    {
        int english, maths, science,sum, avg;
        public Average()//constructor 
        {
            Console.WriteLine("Enter a English subject Marks: ");
            english = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a Maths subject Marks: ");
            maths = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter a science Subject marks");
            science = int.Parse(Console.ReadLine()!);
        }
        public void calculates()
        {
            sum = english + maths + science;
            avg = sum / 3;

        }
        public void print()
        {
            Console.WriteLine("Total Marks: " + sum);
            Console.WriteLine("Average Marks: " + avg);
        }
    }
}
