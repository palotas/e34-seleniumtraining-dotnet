using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTraining
{
    [TestClass]
    public class MoreTests
    {

        [TestCategory("regression")]
        [TestMethod]
        public void groupTest1()
        {
            int a = 1;
            int b = 2;
            int c = a + b;

            Console.WriteLine("c = " + c);
            Assert.IsTrue(c == 3);
        }

    }



}
