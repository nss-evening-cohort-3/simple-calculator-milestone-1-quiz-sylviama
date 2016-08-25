using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class SubtractionFunctions
    {
        [TestMethod]
        public void SubtractionResultNotNull()
        {
            Subtraction subt = new Subtraction();
            int subAnswer = subt.SubtractionOperation(4, 3);
            Assert.IsNotNull(subAnswer);
        }

        [TestMethod]
        public void SubtractionCalculation()
        {
            Subtraction subt = new Subtraction();
            int subAnswer = subt.SubtractionOperation(1, 5);
            Assert.AreEqual(-4, subAnswer);
        }

    }
}
