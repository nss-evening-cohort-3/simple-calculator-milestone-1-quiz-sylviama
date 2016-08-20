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
            int counter = 0;
            while (true)
            {

                Console.Write("[" + counter + "]>");

                string inputString = Console.ReadLine();
                string pattern1 = @"(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)";
                string pattern2 = @"\d";
                string pattern3 = @"(?<constantLetter>[a-zA-Z])(\s?)\=(\s?)(?<constantNumber>\d+)";
                string exitPattern = @"(exit|quit)";

                Match exit = Regex.Match(inputString.ToLower(), exitPattern);
                if (exit.Success == true)
                {
                    break;
                }

                Match m1 = Regex.Match(inputString, pattern1);
                if (m1.Success == true)
                {
                    int number1 = int.Parse(m1.Groups["digit1"].Value);
                    int number2 = int.Parse(m1.Groups["digit2"].Value);
                    string operation = m1.Groups["operation"].Value;
                    if (operation == "+")
                    {
                        Addition addition = new Addition();
                        int additionResult = addition.AdditionOperation(number1, number2);
                        Console.WriteLine("=" + additionResult);
                        counter++;
                        continue;

                        //Modulus modulus = new Modulus();
                        //int modulusResult = modulus.ModulusFunction(-8);
                        //Console.WriteLine(modulusResult);
                    }
                    else if (operation == "-")
                    {
                        Subtraction subtraction = new Subtraction();
                        int subtractionResult = subtraction.SubtractionOperation(number1, number2);
                        Console.WriteLine("=" + subtractionResult);
                        counter++;
                        continue;
                    }
                    else if (operation == "*")
                    {
                        Multiplication multi = new Multiplication();
                        int multiResult = multi.MultiplicationOperation(number1, number2);
                        Console.WriteLine("=" + multiResult);
                        counter++;
                        continue;
                    }
                    else if (operation == "/")
                    {
                        Division divi = new Division();
                        double diviResult = divi.DivisionOperation(number1, number2);
                        Console.WriteLine("=" + diviResult);
                        counter++;
                        continue;
                    }

                }

                Match constantOperation = Regex.Match(inputString, pattern3);
                if (constantOperation.Success == true)
                {
                    Console.WriteLine("Constant");
                    string consLetter = constantOperation.Groups["constantLetter"].Value;
                    double consNumber = int.Parse(constantOperation.Groups["constantNumber"].Value);
                    Console.WriteLine("Saved '" + consLetter + "' as '" + consNumber + "'");
                    counter++;
                    continue;


                }
                //1. repeat
                //2. counter
                //3. catch error
                //4. constant
                //5. modulus
                //6. last




                //string digitString2=Regex.Match(inputString, );

                //Console.WriteLine(digitString1);
            }
                Console.WriteLine("End");
                Console.ReadLine();
            
        }
    }
}
