using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Car:Vehicle
    {
        int noofDoors;
        public void getcar()
        {
            Console.WriteLine("Enter a Number of Doors of the Car: ");
            noofDoors= int.Parse(Console.ReadLine());
        }
        public void displaycar()
        {
            Console.WriteLine("Numbers of Doors of the Car: " + noofDoors);
        }
    }
}
