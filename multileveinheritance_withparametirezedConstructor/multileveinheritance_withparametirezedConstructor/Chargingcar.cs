using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multileveinheritance_withparametirezedConstructor
{
    public class Chargingcar:Car
    {
        int price;
        string fueltype;
        public Chargingcar(int price, string fueltype, string carModel, string color, string name, string type) :base(carModel, color, name, type)
        {
            this.price = price;
            this.fueltype = fueltype;
        }
        public void displaycharging()
        {
            Console.WriteLine("Price of the Charging car: " + price);
            Console.WriteLine("FuelType of the Charging car: " + fueltype);
        }
    }
}
