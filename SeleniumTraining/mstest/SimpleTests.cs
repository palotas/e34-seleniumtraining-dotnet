using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTraining
{
    [TestClass]
    public class SimpleTests
    {
        [TestMethod]
        public void firstTest()
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            Console.Write("c = " + c);
            Assert.IsTrue(c == 3);
        }
    }
}
