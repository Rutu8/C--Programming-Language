using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract public class Construction
    {
        public abstract void land();
        public abstract void plan();
        public abstract void construct();
        public abstract void puja();

        public void celebrate()
        {
            Console.WriteLine("let's Celebrate");
        }
    }
}
