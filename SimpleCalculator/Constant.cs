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
        public void ConstantSetFunction(char x, double y)
        {
            //dic.Add('a', 0.3);

            if(!dic.ContainsKey(x))
            {
                dic.Add(x, y);
                Console.WriteLine("Saved '{0}' as {1}", x, y);
            }
            else
            {
                Console.WriteLine("Error!");
            }  
        }

        //x pattern
        public void ConstantGetFunction(char x)
        {
            foreach (KeyValuePair<char, double> constpair in dic)
            {
                if (constpair.Key== x)
                {
                    Console.WriteLine("{0}", constpair.Value);
                } 
            }
            
        }

        //x+5 pattern
        public void constOperationFunction(char x, string y, int z)
        {
           
            int counter = 0;
            foreach (KeyValuePair<char, double> constpair in dic)
            {
                if (constpair.Key == x)
                {
                    counter++;

                    if(y=="+")
                    {
                        Console.WriteLine("={0}", constpair.Value+z);
                    }else if(y=="-")
                    {
                        Console.WriteLine("={0}", constpair.Value-z);
                    }else if(y=="*")
                    {
                        Console.WriteLine("={0}", constpair.Value*z);
                    }else if(y=="/")
                    {
                        Console.WriteLine("={0}", constpair.Value/z);
                    }
                    
                }
                
            }

            if(counter==0)
            {
                Console.WriteLine("{0} doesn't exist.", x);
            }

        }

        //x+y pattern
    }
}
