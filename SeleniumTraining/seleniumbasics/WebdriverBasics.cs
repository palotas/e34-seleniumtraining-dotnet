using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumTraining
{
    [TestClass]
    public class WebdriverBasics
    {
        [TestMethod]
        public void firstChromeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            String pagetitle = driver.Title;
            Assert.AreEqual("Google", pagetitle);
            driver.Quit();

       }

    }
}
