using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationGetSet
{
    public class Person
    {
        public string Name { get; set; }
        public string adharno { get; set; }

        public void display()
        {
            this.Name = "Rutuja";
        }
        public void display(string name)
        {
            this.Name = name;   
        }
    }
}
