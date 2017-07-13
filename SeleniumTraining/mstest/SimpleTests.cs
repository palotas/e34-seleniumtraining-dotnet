using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTraining
{
    [TestClass]
    public class SimpleTests
    {
        [TestCategory("Nightly"), TestMethod()]
        public void firstTest()
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            Console.Write("c = " + c);
            Assert.IsTrue(c == 3);
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(2)]
        public void dataProviderTestSingleParameter(int value)
        {
            Console.Write("value: " + value);
        }

        [DataTestMethod]
        [DataRow(1, "first")]
        [DataRow(2, "second")]
        public void dataProviderTestMultiParameter(int value, string s)
        {
            Console.Write("value: " + value + "------" + "string: " + s);
        }

    }



}
