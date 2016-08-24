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
            string lastAnswer = "";
            string lastCommand = "";

            while (true)
            {

                Console.Write("[{0}]>", counter);

                string inputString = Console.ReadLine();

                //all the patterns
                
                //exit pattern
                string exitPattern = @"^(exit|quit|EXIT|QUIT)$";
                Match exit = Regex.Match(inputString.ToLower(), exitPattern);

                //lastAnswer Pattern
                string lastAnswerPattern = @"^last$";
                Match lastAnswerP = Regex.Match(inputString.ToLower(), lastAnswerPattern);

                //lastCommand Pattern
                string lastCommandPattern = @"^lastq$";
                Match lastCommandP = Regex.Match(inputString.ToLower(), lastCommandPattern);

                //regular calculation pattern
                string RegurlarCalculationPattern = @"^(?<digit1>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<digit2>[0-9]+)$";
                Match m1 = Regex.Match(inputString, RegurlarCalculationPattern);

                //modulus pattern
                string modulusPattern = @"^\|(?<sign>\-?)(?<number>\d+)\|$";
                Match modulusOperation = Regex.Match(inputString, modulusPattern);

                //x=5 pattern
                string constSetPattern = @"^(?<constantLetter>[a-zA-Z])(\s?)\=(\s?)(?<constantNumber>\d+)$";
                Match constantOperation = Regex.Match(inputString, constSetPattern);

                //x pattern
                string constGetPattern = @"^(?<constLetter>[a-zA-Z])$";
                Match constantGet = Regex.Match(inputString, constGetPattern);

                //x+1 pattern
                string letterPlusNumPattern = @"^(?<const>[a-zA-Z])(?<operation>(\+|\-|\*|\/))(?<digit>[0-9]+)$";
                Match constOperation = Regex.Match(inputString, letterPlusNumPattern);

                //1+x pattern
                string numPlusLetterPattern = @"^(?<digit>[0-9]+)(?<operation>(\+|\-|\*|\/))(?<const>[a-zA-Z])$";
                Match numPlusLetterP = Regex.Match(inputString, numPlusLetterPattern);

                //x+y pattern
                string letterPlusLetterPattern = @"^(?<const1>[a-zA-Z])(?<operation>(\+|\-|\*|\/))(?<const2>[a-zA-Z])$";
                Match letterPlusLetterP = Regex.Match(inputString, letterPlusLetterPattern);



                //exit pattern
                if (exit.Success == true)
                {
                    break;
                }

                //lastAnswer Pattern
                else if (lastAnswerP.Success==true)
                {
                    Console.WriteLine(lastAnswer);
                }

                //lastCommand Pattern
                else if (lastCommandP.Success==true)
                {
                    Console.WriteLine(lastCommand);
                }

                //regular calculation pattern
                else if (m1.Success == true)
                {
                    lastCommand = inputString;
                    
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
                        string diviResult = divi.DivisionOperation(number1, number2);
                        Console.WriteLine("=" + diviResult);
                        lastAnswer = "=" + diviResult;
                        counter++;
                        continue;
                    }

                }

                //modulus pattern
                else if (modulusOperation.Success==true)
                {
                    lastCommand = inputString;
                    
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
                else if (constantOperation.Success == true)
                {
                    lastCommand = inputString;
                    
                    char consLetter = char.Parse(constantOperation.Groups["constantLetter"].Value.ToLower());
                    double consNumber = int.Parse(constantOperation.Groups["constantNumber"].Value);
                    Constant consta = new Constant();
                    lastAnswer = consta.ConstantSetFunction(consLetter, consNumber);
                    counter++;
                    continue;
                }

                //x pattern
                else if(constantGet.Success==true)
                {
                    lastCommand = inputString;
                    
                    char consLetter = char.Parse(constantGet.Groups["constLetter"].Value.ToLower());
                    Constant consGet = new Constant();
                    lastAnswer = consGet.ConstantGetFunction(consLetter);
                    counter++;
                    continue;
                }

                //x+1 pattern
                else if(constOperation.Success==true)
                {
                    lastCommand = inputString;
                    
                    char consLetter = char.Parse(constOperation.Groups["const"].Value.ToLower());
                    string operation = constOperation.Groups["operation"].Value;
                    int number = int.Parse(constOperation.Groups["digit"].Value);
                    Constant constOper = new Constant();
                    lastAnswer = constOper.constOperationFunction(consLetter, operation, number);
                    counter++;
                    continue;   
                }

                //1+x pattern
                else if (numPlusLetterP.Success == true)
                {
                    lastCommand = inputString;
                    
                    char consLetter = char.Parse(numPlusLetterP.Groups["const"].Value.ToLower());
                    string operation = numPlusLetterP.Groups["operation"].Value;
                    int number = int.Parse(numPlusLetterP.Groups["digit"].Value);
                    Constant constOper = new Constant();
                    lastAnswer = constOper.constOperationFunction(consLetter, operation, number);
                    counter++;
                    continue;
                }

                //x+y pattern
                else if(letterPlusLetterP.Success==true)
                {
                    lastCommand = inputString;
                    
                    char consLetter1 = char.Parse(letterPlusLetterP.Groups["const1"].Value.ToLower());
                    string operation = letterPlusLetterP.Groups["operation"].Value;
                    char consLetter2 = char.Parse(letterPlusLetterP.Groups["const2"].Value.ToLower());
                    Constant constOper = new Constant();
                    lastAnswer = constOper.constOperationFunction(consLetter1, operation, consLetter2);
                    counter++;
                    continue;
                }

                else
                {
                    Console.WriteLine("Input Format should be '1+2','|-2|', 'x=1', 'x', 'x+1', '1+x', or 'x+y'");
                    counter++;
                    continue;
                }

                //3. catch error


            }
                Console.WriteLine("End");
                //Console.ReadLine();
            
        }
    }
}
