using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTraining.seleniumbasics
{
    [TestClass]
    public class Seleniumbasicssupport

    {
        [TestMethod]
        public void GetTitle()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            String pagetitle = driver.Title;
            Assert.AreEqual("Google", pagetitle);
            driver.Quit();
        }

        [TestMethod]
        public void Trycatch()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Url = "http://www.google.com";
                String pagetitle = driver.Title;
                Assert.AreEqual("Googl", pagetitle);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void FindElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            driver.FindElement(By.Id("lst-ib")).SendKeys("hello world");
            driver.Quit();
        }
    }
}
