using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndobject_1
{
    // with return type without parameter
    internal class multiplication
    {
        int num1, num2, result;
        public void get()
        {
            Console.WriteLine("Enter a first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            num2 = int.Parse(Console.ReadLine());
 
        }

        public int calculate()
        {
            result = num1 * num2;
            return result;
        }

        //public void display()
        //{
        //    Console.WriteLine("Multiplication is: " + result);
        //}
       
    }
    }

