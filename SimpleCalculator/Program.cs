using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("[X]>");
            string inputString = Console.ReadLine();
            string pattern = @"(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)";
            Match m = Regex.Match(inputString, pattern);
            if(m.Success==true)
            {
                int number1 = int.Parse(m.Groups["digit1"].Value);
                int number2 = int.Parse(m.Groups["digit2"].Value);
                string operation = m.Groups["operation"].Value;
                if(operation=="+")
                {
                    Addition addition = new Addition();
                    int additionResult = addition.AdditionOperation(number1, number2);
                    Console.WriteLine("="+additionResult);

                    Modulus modulus = new Modulus();
                    int modulusResult = modulus.ModulusFunction(-8);
                    Console.WriteLine(modulusResult);
                }else if(operation=="-")
                {
                    Subtraction subtraction = new Subtraction();
                    int subtractionResult = subtraction.SubtractionOperation(number1, number2);
                    Console.WriteLine("=" + subtractionResult);
                }else if(operation=="*")
                {
                    Multiplication multi = new Multiplication();
                    int multiResult = multi.MultiplicationOperation(number1, number2);
                    Console.WriteLine("=" + multiResult);
                }else if(operation=="/")
                {
                    Division divi = new Division();
                    double diviResult = divi.DivisionOperation(number1, number2);
                    Console.WriteLine("=" + diviResult);
                        
                       
         
                }
      
            }


            //string digitString2=Regex.Match(inputString, );

            //Console.WriteLine(digitString1);
            Console.WriteLine("End");
            Console.ReadLine();

        }
    }
}
