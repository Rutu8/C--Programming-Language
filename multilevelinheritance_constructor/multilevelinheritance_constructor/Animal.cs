using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance_constructor
{
    public class Animal
    {
        string eat, run;
        public Animal()
        {
            Console.WriteLine("Can Animals eat: ");
            eat = Console.ReadLine()!;
            Console.WriteLine("Can Animals Run:");
            run = Console.ReadLine()!;
        }

        public void displayanimal()
        {
            Console.WriteLine("Animals Can Eat:" + eat);
            Console.WriteLine("Animals Can Run:" + run);
        }
    }
}
