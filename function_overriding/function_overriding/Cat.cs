using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_overriding
{
    public class Cat : Animal
    {
        public void get()//child function override
        {
            Console.WriteLine("I am child");

        }
    }
}
