using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace withparameter_withreturntype_classObject
{
    internal class Division
    {
        int n1, n2, result;
        public int getData(int num1, int num2)
        {
            n1 = num1;
            n2 = num2;
            result = n1 / n2;
            return result;

        }
    }
}
