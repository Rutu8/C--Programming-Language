using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleInheritance_same_methods
{
    public class Employee : Person, Iteacher
    {
        public void show()
        {
            Console.WriteLine("Employee Show");
        }
       
        void Iteacher.show()//Explicit Implementation
        {
            Console.WriteLine("Hello this is interface");
        }

    }
}
