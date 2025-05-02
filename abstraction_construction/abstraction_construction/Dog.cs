using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_construction
{
    class Dog : Animal
    {
        private string name;

        public Dog(string dogName)
        {
            name = dogName;
            Console.WriteLine("Dog constructor called.");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Dog-specific initialization logic.");
        }
    }
}
