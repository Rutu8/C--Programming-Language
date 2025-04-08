using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_singleInheritance
{
    public class Animal
    {
        string eat, run;
        public Animal(string eat, string run) 
        { 
            this.eat = eat;
            this.run = run;
        } 
        public void  displayanimal()
        {
            Console.WriteLine("Animals Can Eat: " + eat);
            Console.WriteLine("Animals Can Run: " + run);
        }
    }
}
