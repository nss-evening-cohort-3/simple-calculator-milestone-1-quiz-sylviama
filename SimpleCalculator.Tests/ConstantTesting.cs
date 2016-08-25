using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ConstantTesting
    {
        //public static Dictionary<char, double> dic = new Dictionary<char, double>();

        [TestMethod]
        public void AssignAValueToACharDoesntHaveAValue()
        {
            Constant consta = new Constant();
            string constResult = consta.ConstantSetFunction('a', 0.3);
            Assert.IsNotNull(constResult);

        }
    }
}
