using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Truck: Vehicle
    {
        int maximumLoadCapacity;
        public void gettruck()
        {
            Console.WriteLine("Enter a Maximum Load Capacity of the Truck: ");
            maximumLoadCapacity = int.Parse(Console.ReadLine()!);
        }
        public void displaytruck()
        {
            Console.WriteLine("Maximum Load Capacity of the Truck: " + maximumLoadCapacity);
        }
    }
}
