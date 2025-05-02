using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance_constructor
{
    public class Cat:Dog
    {
        string name;
        string sound;

        public Cat() 
        {
            Console.WriteLine("Name of the cat class Animal: ");
            name = Console.ReadLine();
            Console.WriteLine("Sound of the Animal: " + " " + name + ":");
            sound = Console.ReadLine();

        }

        public void displaycat()
        {
            Console.WriteLine("Name of the Animal: " + name);
            Console.WriteLine("Sound of the Animal: " + name+" :"+sound);
        }
    }
}
