using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance
{
    public class Employee:Person
    {
        int id;
        string department_name;
        public void getemp()
        {
            Console.WriteLine("Enter a id: " );
            id = int.Parse( Console.ReadLine()! );
            Console.WriteLine("Enter a Department Name:  " );
            department_name = Console.ReadLine()!;
        }

        public void displayemp()
        {
            Console.WriteLine("Id of Employee: " + id);
            Console.WriteLine("Id of Employee: " + department_name);


        }
    }
}
