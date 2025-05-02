using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Polymorphismcs
    {


       //Function Overloading with same methods different parameters and different datatypes also
        public void show(int num1, int num2)
        {
           
            Console.WriteLine("Addition is: " + (num1+num2));

        }

        public void show(int num1, string message)
        {
            Console.WriteLine("Concatenation:"+(num1+" "+message));

        }

        public void show(float num1, float num2)
        {
            Console.WriteLine("Addition of float no: "+(num1+num2));
        }
        public void show(int num1,int num2,int num3)
        {
            Console.WriteLine("Addition of three numbers: " + (num1+num2+num3));

        }

    }
}
