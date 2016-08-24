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

        [TestMethod]
        public void DivisionRegular()
        {
            Division div = new Division();
            string divResult = div.DivisionOperation(10,5);
            Assert.AreEqual("2", divResult);
        }

        [TestMethod]
        public void DivisionWithDecimalResult()
        {
            Division div = new Division();
            string divResult = div.DivisionOperation(2, 4);
            Assert.AreEqual("0.5", divResult);
        }

        [TestMethod]
        public void DividedBy0ShouldBeNull()
        {
            Division div = new Division();
            string divResult = div.DivisionOperation(99, 0);
            Assert.IsNull(divResult);
        }
    }
}
