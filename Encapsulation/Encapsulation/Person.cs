using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Person
    {
        private string name;
        private string adharno;

        public void setName(string name)
        {
            if (name.Length >=5)
            {
                this.name = name;
            }
        }
        public string getname()
        {
            return this.name;
        }

        public void setaadharno(string adharno)
        {
            if(adharno.Length == 12)
            {
                this.adharno = adharno;
            }

        }

        public string getadharno()
        {
            return this.adharno;
        }

    }
}
