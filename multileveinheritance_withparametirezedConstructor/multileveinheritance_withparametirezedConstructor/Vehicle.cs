using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multileveinheritance_withparametirezedConstructor
{
    public class Vehicle
    {
        string name;
        string type;
        public Vehicle(string name, string type)
        {
            this.name = name;
            this.type = type;

        }
        public void displayvehicle()
        {
            Console.WriteLine("Name of the vehicle: " + name);
            Console.WriteLine("Type of the vehicle: " + type);//type taxi or  suv , transportation

        }
    }
}
