using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Employee:Person
    {
        int id, salary;
        string department;
         

        public void getDataemp()
        {
            Console.WriteLine("Enter a Id: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
            salary = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Department Name: ");
            department = Console.ReadLine();
        }
        public void displayemp()
        {
            Console.WriteLine("Id is: " + id);
            Console.WriteLine("Salary is: " + salary);
            Console.WriteLine("Department is: " + department);
        }

    }
}
