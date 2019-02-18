using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace SeleniumTraining.seleniumbasics
{
    [TestClass]
    public class RemoteWebdriver
    {
        [TestMethod]
        public void remoteWebdriver()
        {
            RemoteWebDriver driver;
          /*  DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
            driver = new RemoteWebDriver(capabilities);
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine(driver.Title);            
            driver.Quit();*/
        }
    }
}
