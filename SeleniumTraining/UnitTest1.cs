using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstSeleniumTest()
        {
            IWebDriver driver = new ChromeDriver();
            try
            {
                driver.Url = "http://www.google.com";
                String pagetitle = driver.Title;
                Assert.AreEqual("Google", pagetitle);
            }
            finally
            {
                driver.Quit();

            }
        }
    }
}
