using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{
    public class Employee:Person, Iteacher
    {
        public void show()
        {
            Console.WriteLine("Hello I am Employee");

        }

        public void present()
        {
            Console.WriteLine("Hello I am interface Employee");
        }
    }
}
