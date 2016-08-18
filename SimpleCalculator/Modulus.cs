using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Modulus
    {
        public int ModulusFunction(int number)
        {
            if(number>=0)
            {
                return number;
            }
            else
            {
                return -number;
            }
        }
    }
}
