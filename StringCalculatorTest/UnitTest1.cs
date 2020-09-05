using System;
using StringCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("0", "0", "0")]
        [DataRow("0", "1", "1")]
        [DataRow("1", "0", "1")]
        [DataRow("1", "1", "2")]
        [DataRow("99", "99", "198")]
        [DataRow("9", "1999", "2008")]
        [DataRow("9999999999999999999999999999", "8888888888888888", "10000000000008888888888888887")]
        public void TestAdder(string a, string b, string expected)
        {
            var adder = new StringAdder();
            var sum = adder.add(a, b);
            Assert.AreEqual(expected, sum);
        }

        [TestMethod]
        [DataRow("0", "0", "0")]
        [DataRow("0", "1", "0")]
        [DataRow("1", "0", "0")]
        [DataRow("1", "1", "1")]
        [DataRow("1", "2", "2")]
        [DataRow("99", "99", "9801")]
        [DataRow("9", "999", "8991")]
        [DataRow("1024", "1024", "1048576")]
        [DataRow("1048576", "1048576", "1099511627776")]
        [DataRow("1048576", "1099511627776", "1152921504606846976")]
        [DataRow("1099511627776", "1152921504606846976", "1267650600228229401496703205376")]
        public void TestMultiplier(string a, string b, string expected)
        {
            var multiplier = new StringMultiplier();
            var product = multiplier.multiply(a, b);
            Assert.AreEqual(expected, product);
        }
    }
}
