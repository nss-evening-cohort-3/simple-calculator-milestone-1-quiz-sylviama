using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SimpleCalculator
{
    public class Constant

    {
        public static Dictionary<char, double> dic = new Dictionary<char, double>();
        
        //x=5 pattern
        public string ConstantSetFunction(char x, double y)
        {
            //dic.Add('a', 0.3);

            if(!dic.ContainsKey(x))
            {
                dic.Add(x, y);
                Console.WriteLine("Saved '{0}' as {1}", x, y);
                return "Saved " + x + " as " + y;
            }
            else
            {
                Console.WriteLine("Error!");
                return "Error";
            }  
        }

        //x pattern
        public string ConstantGetFunction(char x)
        {
            foreach (KeyValuePair<char, double> constpair in dic)
            {
                if (constpair.Key== x)
                {
                    Console.WriteLine("{0}", constpair.Value);
                    return Convert.ToString(constpair.Value);
                }
                
            }

            return null;
            
        }

        //x+5 pattern
        public string constOperationFunction(char x, string y, int z)
        {
           
            int counter = 0;
            foreach (KeyValuePair<char, double> constpair in dic)
            {
                if (constpair.Key == x)
                {
                    counter++;

                    if(y=="+")
                    {
                        double result = constpair.Value + z;
                        Console.WriteLine("={0}", result);
                        return "=" + result;
                    }else if(y=="-")
                    {
                        double result = constpair.Value - z;
                        Console.WriteLine("={0}", result);
                        return "=" + result;
                    }else if(y=="*")
                    {
                        double result = constpair.Value*z;
                        Console.WriteLine("={0}", result);
                        return "=" + result;
                    }else if(y=="/")
                    {
                        double result = constpair.Value / z;
                        Console.WriteLine("={0}", result);
                        return "=" + result;
                    }
                    
                }
                
            }
            
            if(counter==0)
            {
                Console.WriteLine("{0} doesn't exist.", x);
                return null;
            }

            return null;

        }

        //x+y pattern
        public string constOperationFunction(char x, string y, char z)
        {

            int counter1 = 0;
            int counter2 = 0;
            foreach (KeyValuePair<char, double> constpair in dic)
            {
                if (constpair.Key == x)
                {
                    counter1++;

                    foreach(KeyValuePair<char, double> constpair2 in dic)
                    {
                        if(constpair2.Key==z)
                        {
                            counter2++;

                            if (y == "+")
                            {
                                double result = constpair.Value + constpair2.Value;
                                Console.WriteLine("={0}", result);
                                return "=" + result;
                            }
                            else if (y == "-")
                            {
                                double result = constpair.Value - constpair2.Value;
                                Console.WriteLine("={0}", result);
                                return "=" + result;
                            }
                            else if (y == "*")
                            {
                                double result = constpair.Value * constpair2.Value;
                                Console.WriteLine("={0}", result);
                                return "=" + result;
                            }
                            else if (y == "/")
                            {
                                double result = constpair.Value / constpair2.Value;
                                Console.WriteLine("={0}", result);
                                return "=" + result;
                            }
                        }
                    }
                }

            }

            if (counter1 == 0|counter2==0)
            {
                Console.WriteLine("{0} or {1} doesn't exist.", x, z);
                return null;
            }

            return null;

        }

    }
}
