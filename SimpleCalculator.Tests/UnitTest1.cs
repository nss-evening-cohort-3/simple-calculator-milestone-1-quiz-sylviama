using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionFunction
    {
        [TestMethod]
        public void AdditionResultNotNull()
        {
            Addition addi = new Addition();
            int addiAnswer = addi.AdditionOperation(2, 4);
            Assert.IsNotNull(addiAnswer);
        }

        [TestMethod]
        public void AdditionCalculation()
        {
            Addition addi = new Addition();
            int addiAnswer = addi.AdditionOperation(7, 4);
            Assert.AreEqual(11, addiAnswer);
        }

        

        

        
    }
}
