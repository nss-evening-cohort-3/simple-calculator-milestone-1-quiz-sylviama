using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("[X]>");
            string inputString = Console.ReadLine();
            string pattern = @"(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)";
            Match m = Regex.Match(inputString, pattern);
            if(m.Success==true)
            {
                Console.WriteLine(m.Groups["digit1"].Value);
                Console.WriteLine(m.Groups["operation"].Value);
                Console.WriteLine(m.Groups["digit2"].Value);
            }


            //string digitString2=Regex.Match(inputString, );

            //Console.WriteLine(digitString1);
            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
