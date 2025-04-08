using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_singleInheritance
{
    public class Dog:Animal
    {
        string name, sound;
        public Dog(string name, string sound, string eat, string run):base(eat, run)
        {
            this.name = name;
            this.sound = sound;
        }

        public void getdisplayDog()
        {
            Console.WriteLine("Name of the Dog : " + name);
            Console.WriteLine("Sound of Dog: " + sound);

        }
    }
}
