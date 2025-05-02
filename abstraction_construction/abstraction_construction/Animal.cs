using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_construction
{
    abstract class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor called.");
            Initialize(); // Call abstract method from constructor
        }

        // Abstract "construction" logic
        protected abstract void Initialize();
    }
}
