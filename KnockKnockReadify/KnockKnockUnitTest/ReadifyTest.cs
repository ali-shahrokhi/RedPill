using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnockReadify;

namespace KnockKnockUnitTest
{
    [TestClass]
    public class ReadifyTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FibonnaciException()
        {
            var result = Helper.Fibonacci(100);
        }

        [TestMethod]
        public void FibonnaciAccuracyTest()
        {
            var result = Helper.Fibonacci(5);
            Assert.AreEqual(5, result);
            Assert.AreNotEqual(-5, result);
        }
    }
}
