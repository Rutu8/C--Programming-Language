using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_celsiusanddegree
{
    internal class Temperature
    {
        int c, fahrenheit;
        public Temperature(int c)
        {
            // this keyword
            this.c = c;
           

        }
        public void calculate()
        {
            fahrenheit = (c * 9 / 5) + 32;

        }
        public int gettemperature()
        {
            return fahrenheit;

        }

    }
}
