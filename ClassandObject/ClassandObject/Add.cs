using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
    internal class Add
    {

        public int num1, num2, result;

        public void getData()
        {
            Console.WriteLine("Enter a Two Numbers: ");
            num1 = int.Parse(Console.ReadLine()!);
            num2 = int.Parse(Console.ReadLine()!) ;

        }
        public void calculate()
        {
            result = num1 + num2;
        }

        public void display()
        {
            Console.WriteLine("Addition is: " + result);

        }

    }
}
