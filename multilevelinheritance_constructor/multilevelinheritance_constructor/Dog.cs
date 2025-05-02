using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevelinheritance_constructor
{
    public class Dog:Animal
    {
        string name;
        int num;
        public Dog() 
        {
            Console.WriteLine("Enter a Name of the dog class Animal: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter a Numbers of the Animals: " + name + ":");
            num = int.Parse(Console.ReadLine()!);
        }

        public void displaydog()
        {
            Console.WriteLine("Name of the Animal is: " + name);
            Console.WriteLine("Numbers of the Animals: " +name +" :"+num);
        }
    }
}
