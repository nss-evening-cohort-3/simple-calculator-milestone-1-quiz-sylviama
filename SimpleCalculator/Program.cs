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

                Console.Write("[{0}]>", counter);

                string inputString = Console.ReadLine();
                string RegurlarCalculationPattern = @"(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)$";
                string modulusPattern = @"\|(?<sign>\-?)(?<number>\d+)\|$";
                string constSetPattern = @"(?<constantLetter>[a-zA-Z])(\s?)\=(\s?)(?<constantNumber>\d+)$";
                string exitPattern = @"(exit|quit)";
                string constGetPattern = @"(?<constLetter>[a-z])$";
                string constOperationPattern = @"(?<const>[a-zA-Z])(?<operation>(\+|\-|\*|\/))(?<digit>[0-9]+)$";

                //exit pattern
                Match exit = Regex.Match(inputString.ToLower(), exitPattern);
                if (exit.Success == true)
                {
                    break;
                }

                //regular calculation pattern
                Match m1 = Regex.Match(inputString, RegurlarCalculationPattern);
                if (m1.Success == true)
                {
                    Console.WriteLine("regular operation");
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

                //modulus pattern
                Match modulusOperation = Regex.Match(inputString, modulusPattern);
                if(modulusOperation.Success==true)
                {
                    Console.WriteLine("Modulus Pattern");
                    int modulusNum = int.Parse(modulusOperation.Groups["number"].Value);
                    string ifSign = modulusOperation.Groups["sign"].Value;
                    Modulus modulus = new Modulus();
                    int modulusResult = modulus.ModulusFunction(ifSign, modulusNum);
                    Console.WriteLine(modulusResult);
                    counter++;
                    continue;

                }

                //x=5 pattern
                Match constantOperation = Regex.Match(inputString, constSetPattern);
                if (constantOperation.Success == true)
                {
                    Console.WriteLine("x=5 pattern");
                    char consLetter = char.Parse(constantOperation.Groups["constantLetter"].Value);
                    double consNumber = int.Parse(constantOperation.Groups["constantNumber"].Value);
                    Constant consta = new Constant();
                    consta.ConstantSetFunction(consLetter, consNumber);
                    counter++;
                    continue;
                }

                //x pattern
                Match constantGet = Regex.Match(inputString, constGetPattern);
                if(constantGet.Success==true)
                {
                    Console.WriteLine("x pattern");
                    char consLetter = char.Parse(constantGet.Groups["constLetter"].Value);
                    Constant consGet = new Constant();
                    consGet.ConstantGetFunction(consLetter);
                    counter++;
                    continue;
                }

                //x+1 pattern
                Match constOperation = Regex.Match(inputString, constOperationPattern);
                if(constOperation.Success==true)
                {
                    Console.WriteLine("constant + 1 pattern");
                    char consLetter = char.Parse(constOperation.Groups["const"].Value);
                    string operation = constOperation.Groups["operation"].Value;
                    int number = int.Parse(constOperation.Groups["digit"].Value);
                    Constant constOper = new Constant();
                    constOper.constOperationFunction(consLetter, operation, number);
                    counter++;
                    continue;
                    
                }
                
                //3. catch error
                //4. constant
                //5. modulus
                //6. last

            }
                Console.WriteLine("End");
                Console.ReadLine();
            
        }
    }
}
