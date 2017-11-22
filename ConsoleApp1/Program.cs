using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Running test");

            ChromeOptions options = new ChromeOptions();

            DesiredCapabilities dc = (DesiredCapabilities)options.ToCapabilities();

            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc);

            driver.Navigate().GoToUrl("https://www.lhsystems.com");

            driver.Quit();

        }
    }
}