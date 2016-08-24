using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Division
    {
        public string DivisionOperation(int number1, int number2)
        {
            if (number2 != 0)
            {
                double num1 = Convert.ToDouble(number1);
                double num2 = Convert.ToDouble(number2);
                return Convert.ToString(num1 / num2);
            }
            else
            {
                Console.WriteLine("Dividing by 0 is not allowed.");
                return null;
            }
        }
    }
}
