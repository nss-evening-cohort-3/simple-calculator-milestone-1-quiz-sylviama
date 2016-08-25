using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculator.Tests
{
    [TestClass]
    public class DivisionTesting
    {
        [TestMethod]
        public void DivisionRegular()
        {
            Division div = new Division();
            string divResult = div.DivisionOperation(10, 5);
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
