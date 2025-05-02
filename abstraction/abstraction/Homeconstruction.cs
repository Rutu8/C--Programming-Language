using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    public class Homeconstruction: Construction
    {
        public override void land()
        {
            Console.WriteLine("Get Land");

        }

        public override void plan()
        {
            Console.WriteLine("Plan Construction");

        }

        public override void construct()
        {
            Console.WriteLine("Construct Home");

        }

        public override void puja()
        {
            Console.WriteLine("Do Puja");

        }


    }
}
