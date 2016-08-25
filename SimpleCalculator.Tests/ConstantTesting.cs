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
        public void ConstTestAssignAValueToACharDoesntHaveAValueResultShouldNotBeNull()
        {
            Constant consta = new Constant();
            string constResult = consta.ConstantSetFunction('a', 0.3);
            Assert.IsNotNull(constResult);
        }

        [TestMethod]
        public void ConstTestAssignAValueToACharDoesntHaveAValue()
        {
            Constant consta = new Constant();
            string constResult = consta.ConstantSetFunction('x', 3);
            Assert.AreEqual("Saved x as 3", constResult);
        }

        
        [TestMethod]
        public void ConstTestAssignAValueToACharAlreadyHasAValue()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('a', 9);
            string constResult = consta.ConstantSetFunction('a', 10);
            Assert.AreEqual("Error", constResult);
        }


        [TestMethod]
        public void ConstTestGetAnExistingValueIsNotNull()
        {
            Constant consta = new Constant();
            string constResult = consta.ConstantSetFunction('b', 8);
            string constResult2 = consta.ConstantGetFunction('b');
            Assert.IsNotNull(constResult2);

        }

        [TestMethod]
        public void ConstTestGetAnExistingValue()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('c', 9);
            string constResult = consta.ConstantGetFunction('c');
            Assert.AreEqual("9", constResult);
        }

        [TestMethod]
        public void ConstTestTypeOfOutputValue()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('d', 4);
            string constResult = consta.ConstantGetFunction('d');
            Assert.AreEqual(typeof(string), constResult.GetType());
        }

        [TestMethod]
        public void ConstTestGetACharDoesntHaveAValue()
        {
            Constant consta = new Constant();
            string constResult = consta.ConstantGetFunction('e');
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestCharPlusNum()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('f', 4);
            string constResult= consta.constOperationFunction('f', "+", 5);
            Assert.AreEqual("=9", constResult);
        }

        [TestMethod]
        public void ConstTestEmptyCharPlusNum()
        {
            Constant consta = new Constant();
            string constResult = consta.constOperationFunction('k', "+", 5);
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestCharMinusNum()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('g', 7);
            string constResult = consta.constOperationFunction('g', "-", 5);
            Assert.AreEqual("=2", constResult);
        }

        [TestMethod]
        public void ConstTestEmptyCharMinusNum()
        {
            Constant consta = new Constant();
            string constResult = consta.constOperationFunction('l', "-", 5);
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestCharTimesNum()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('h', 7);
            string constResult = consta.constOperationFunction('h', "*", 5);
            Assert.AreEqual("=35", constResult);
        }

        [TestMethod]
        public void ConstTestEmptyCharTimesNum()
        {
            Constant consta = new Constant();
            string constResult = consta.constOperationFunction('m', "*", 5);
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestCharDivideNum()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('i', 10);
            string constResult = consta.constOperationFunction('i', "/", 5);
            Assert.AreEqual("=2", constResult);
        }

        [TestMethod]
        public void ConstTestEmptyCharDivideNum()
        {
            Constant consta = new Constant();
            string constResult = consta.constOperationFunction('n', "/", 5);
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestCharDivideNum0()
        {
            Constant consta = new Constant();
            consta.ConstantSetFunction('j', 8);
            string constResult = consta.constOperationFunction('j', "/", 0);
            Assert.IsNull(constResult);
        }

        [TestMethod]
        public void ConstTestEmptyCharDivideNum0()
        {
            Constant consta = new Constant();
            string constResult = consta.constOperationFunction('o', "/", 0);
            Assert.IsNull(constResult);
        }




    }
}
