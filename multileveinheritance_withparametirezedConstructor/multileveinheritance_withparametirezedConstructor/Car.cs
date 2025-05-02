using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multileveinheritance_withparametirezedConstructor
{
    public class Car:Vehicle
    {
        string carModel, color;
        public Car(string carModel, string color, string name, string type):base(name, type)
        {
            this.carModel = carModel;
            this.color = color;

        }
        public void displaycar()
        {
            Console.WriteLine("Car Model is: " + carModel);
            Console.WriteLine("Color of the Car is: " +  color);
        }
    }
}
