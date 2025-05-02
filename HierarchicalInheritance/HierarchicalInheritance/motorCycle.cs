using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class motorCycle: Vehicle
    {
        string hasSidecar;

        public void getmotor()
        {
            Console.WriteLine("Enter a Motor Cycle has side Car: ");
            hasSidecar = Console.ReadLine()!;
        }
        public void displaymotor()
        {
            Console.WriteLine("Motor Cycle has side Car: " + hasSidecar);
        }
    }
}
