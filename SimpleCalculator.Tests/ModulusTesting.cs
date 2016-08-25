using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ModulusTesting
    {
        [TestMethod]
        public void ModulusResultNotNull()
        {
            Modulus mud = new Modulus();
            int mudResult = mud.ModulusFunction("+", 3);
            Assert.IsNotNull(mudResult);
        }

        [TestMethod]
        public void MudulusPositiveInput()
        {
            Modulus mud = new Modulus();
            int mudResult = mud.ModulusFunction("", 5);
            Assert.AreEqual(5, mudResult);
        }

        [TestMethod]
        public void MudulusNegativeInput()
        {
            Modulus mud = new Modulus();
            int mudResult = mud.ModulusFunction("-", 9);
            Assert.AreEqual(9, mudResult);
        }

        [TestMethod]
        public void Mudulus0Input()
        {
            Modulus mud = new Modulus();
            int mudResult = mud.ModulusFunction("", 0);
            Assert.AreEqual(0, mudResult);
        }

    }
}
