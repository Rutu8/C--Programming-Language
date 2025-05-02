using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Home : Construction
    {
        public void land()
        {
            Console.WriteLine("Buy Land");
        }

        public void plan()
        {
            Console.WriteLine("Do Plan");
        }

        public void construct()
        {
            Console.WriteLine("Construct the building");
        }

        public void puja()
        {
            Console.WriteLine("Do Puja");
        }

        public void celebrate()
        {
            Console.WriteLine("Let,s Celebrate...");
        }

    }
}
