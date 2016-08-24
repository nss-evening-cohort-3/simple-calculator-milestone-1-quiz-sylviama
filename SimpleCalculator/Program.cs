﻿using System;
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
            string lastAnswer = "";
            string lastCommand = "";

            while (true)
            {

                Console.Write("[{0}]>", counter);

                string inputString = Console.ReadLine();
                string RegurlarCalculationPattern = @"(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)$";
                string modulusPattern = @"\|(?<sign>\-?)(?<number>\d+)\|$";
                string constSetPattern = @"(?<constantLetter>[a-zA-Z])(\s?)\=(\s?)(?<constantNumber>\d+)$";
                string exitPattern = @"(exit|quit)$";
                string constGetPattern = @"^(?<constLetter>[a-z])$";
                string constOperationPattern = @"^((?<const>[a-zA-Z])(?<operation>(\+|\-|\*|\/))(?<digit>[0-9]+))|
((?<digit>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<const>[a-zA-Z]))$";
                string lastAnswerPattern = @"last$";
                string lastCommandPattern = @"lastq$";

                //exit pattern
                Match exit = Regex.Match(inputString.ToLower(), exitPattern);
                if (exit.Success == true)
                {
                    break;
                }

                //lastAnswer Pattern
                Match lastAnswerP = Regex.Match(inputString.ToLower(), lastAnswerPattern);
                if(lastAnswerP.Success==true)
                {
                    Console.WriteLine(lastAnswer);
                }

                //lastCommand Pattern
                Match lastCommandP = Regex.Match(inputString.ToLower(), lastCommandPattern);
                if(lastCommandP.Success==true)
                {
                    Console.WriteLine(lastCommand);
                }

                //regular calculation pattern
                Match m1 = Regex.Match(inputString, RegurlarCalculationPattern);
                if (m1.Success == true)
                {
                    lastCommand = inputString;
                    Console.WriteLine("regular operation");
                    int number1 = int.Parse(m1.Groups["digit1"].Value);
                    int number2 = int.Parse(m1.Groups["digit2"].Value);
                    string operation = m1.Groups["operation"].Value;
                    if (operation == "+")
                    {
                        Addition addition = new Addition();
                        int additionResult = addition.AdditionOperation(number1, number2);
                        Console.WriteLine("=" + additionResult);
                        lastAnswer = "=" + additionResult;
                        counter++;
                        continue;

                        
                    }
                    else if (operation == "-")
                    {
                        Subtraction subtraction = new Subtraction();
                        int subtractionResult = subtraction.SubtractionOperation(number1, number2);
                        Console.WriteLine("=" + subtractionResult);
                        lastAnswer = "=" + subtractionResult;
                        counter++;
                        continue;
                    }
                    else if (operation == "*")
                    {
                        Multiplication multi = new Multiplication();
                        int multiResult = multi.MultiplicationOperation(number1, number2);
                        Console.WriteLine("=" + multiResult);
                        lastAnswer = "=" + multiResult;
                        counter++;
                        continue;
                    }
                    else if (operation == "/")
                    {
                        Division divi = new Division();
                        double diviResult = divi.DivisionOperation(number1, number2);
                        Console.WriteLine("=" + diviResult);
                        lastAnswer = "=" + diviResult;
                        counter++;
                        continue;
                    }

                }

                //modulus pattern
                Match modulusOperation = Regex.Match(inputString, modulusPattern);
                if(modulusOperation.Success==true)
                {
                    lastCommand = inputString;
                    Console.WriteLine("Modulus Pattern");
                    int modulusNum = int.Parse(modulusOperation.Groups["number"].Value);
                    string ifSign = modulusOperation.Groups["sign"].Value;
                    Modulus modulus = new Modulus();
                    int modulusResult = modulus.ModulusFunction(ifSign, modulusNum);
                    Console.WriteLine(modulusResult);
                    lastAnswer = Convert.ToString(modulusResult);
                    counter++;
                    continue;

                }

                //x=5 pattern
                Match constantOperation = Regex.Match(inputString, constSetPattern);
                if (constantOperation.Success == true)
                {
                    lastCommand = inputString;
                    Console.WriteLine("x=5 pattern");
                    char consLetter = char.Parse(constantOperation.Groups["constantLetter"].Value);
                    double consNumber = int.Parse(constantOperation.Groups["constantNumber"].Value);
                    Constant consta = new Constant();
                    lastAnswer = consta.ConstantSetFunction(consLetter, consNumber);
                    counter++;
                    continue;
                }

                //x pattern
                Match constantGet = Regex.Match(inputString, constGetPattern);
                if(constantGet.Success==true)
                {
                    lastCommand = inputString;
                    Console.WriteLine("x pattern");
                    char consLetter = char.Parse(constantGet.Groups["constLetter"].Value);
                    Constant consGet = new Constant();
                    lastAnswer = consGet.ConstantGetFunction(consLetter);
                    counter++;
                    continue;
                }

                //x+1 pattern
                Match constOperation = Regex.Match(inputString, constOperationPattern);
                if(constOperation.Success==true)
                {
                    lastCommand = inputString;
                    Console.WriteLine("constant + 1 pattern");
                    char consLetter = char.Parse(constOperation.Groups["const"].Value);
                    string operation = constOperation.Groups["operation"].Value;
                    int number = int.Parse(constOperation.Groups["digit"].Value);
                    Constant constOper = new Constant();
                    lastAnswer = constOper.constOperationFunction(consLetter, operation, number);
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
