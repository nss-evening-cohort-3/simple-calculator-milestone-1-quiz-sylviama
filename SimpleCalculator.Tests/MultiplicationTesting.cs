using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplicationTesting
    {
        [TestMethod]
        public void MultiplicationNotNull()
        {
            Multiplication multi = new Multiplication();
            int multiAnswer = multi.MultiplicationOperation(2, 7);
            Assert.IsNotNull(multiAnswer);
        }

        [TestMethod]
        public void MultiplicationCalculation()
        {
            Multiplication multi = new Multiplication();
            int multiAnswer = multi.MultiplicationOperation(3, 5);
            Assert.AreEqual(15, multiAnswer);
        }

        [TestMethod]
        public void MultiplicationCalWith0()
        {
            Multiplication multi = new Multiplication();
            int multiAnswer = multi.MultiplicationOperation(0, 9);
            Assert.AreEqual(0, multiAnswer);
        }
    }
}
