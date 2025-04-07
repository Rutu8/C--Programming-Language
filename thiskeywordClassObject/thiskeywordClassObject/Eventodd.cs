using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeywordClassObject
{
    internal class Eventodd
    {
        int num1;
        public void getData(int num1)
        {
            //this keyword
            this.num1 = num1;
            
        }
        public void calculation()
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
        }
    }
}
