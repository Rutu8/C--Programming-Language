using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndobject_1
{
    public class Addition
    {
        int num1, num2, result;

        // here we used parameter function with no return type
        public void getdata(int n1, int n2)
        {
            num1 = n1;//here we assign number to n1
            num2 = n2;
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
