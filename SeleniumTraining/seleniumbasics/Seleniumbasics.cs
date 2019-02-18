using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;

namespace SeleniumTraining
{
    [TestClass]
    public class Seleniumbasics

    {

        [TestMethod]
        public void ffTests()
        {
            FirefoxOptions options = new FirefoxOptions();

            DesiredCapabilities dc = (DesiredCapabilities)options.ToCapabilities();
            dc.SetCapability("e34:token", "19705d15-03b8-4f");


            IWebDriver driver = new RemoteWebDriver(new Uri("http://vm-106.element34.net/wd/hub"), dc);
            //IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc);

            driver.Navigate().GoToUrl("https://www.google.ch");
            Assert.IsTrue(driver.Url.StartsWith("https://www.google.ch", StringComparison.InvariantCultureIgnoreCase));

            driver.Quit();

        }



        [TestMethod]
        public void firstChromeTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.google.com";
            driver.Quit();
       }

        [TestMethod]
        public void chromeTests()
        {
           System.Diagnostics.Debug.WriteLine("Hello world");

            ChromeOptions browserOptions = new ChromeOptions();
            browserOptions.AddArgument("--enable--javascript");
            browserOptions.AddArgument("--start-maximized");
            browserOptions.AddAdditionalCapability("takesScreenshot", true, true);
            browserOptions.AddAdditionalCapability("e34:l_testName", "bmw test", true);
            browserOptions.AddAdditionalCapability("e34:token", "19705d15-03b8-4f", true);

            Console.WriteLine(browserOptions.ToCapabilities());

           // FirefoxOptions ff = new FirefoxOptions();
            
            //DesiredCapabilities dc = (DesiredCapabilities)ff.ToCapabilities(); 
            
           // dc.SetCapability("e34:token", "19705d15-03b8-4f");
            //dc.SetCapability("e34:l_testName", "bmw test2");
           // Console.WriteLine(dc);




            IWebDriver driver = new RemoteWebDriver(new Uri("http://vm-106.element34.net/wd/hub"), browserOptions);
            //IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc);

            driver.Navigate().GoToUrl("https://www.google.ch");
            Assert.IsTrue(driver.Url.StartsWith("https://www.google.ch", StringComparison.InvariantCultureIgnoreCase));

           driver.Quit();
            
        }
        [TestMethod]
        public void lhtestChrome()
        {
            Console.WriteLine("hello world");

            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--test-type");
            //options.AddUserProfilePreference(DriversConstant.ChromeProfile.DownloadPromptForDownload, true);

            DesiredCapabilities dc = (DesiredCapabilities)options.ToCapabilities();
            //dc.SetCapability("version", "61");


            //DesiredCapabilities capability = DesiredCapabilities.Chrome();
            //capability.SetCapability("version", "61");
            IWebDriver driver = new RemoteWebDriver(new Uri("http://vm-106.element34.net/wd/hub"), dc);

            //IWebDriver driver = new RemoteWebDriver(new Uri("http://192.168.34.12:4444/wd/hub/"), dc);
            //IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc);

            driver.Navigate().GoToUrl("http://www.google.com/ncr");
            Console.WriteLine(driver.Title);

            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("TestingBot");
            query.Submit();
            Console.WriteLine(driver.Title);

            driver.Quit();
        }

        [TestMethod]
        public void ieTest()
        {
            //InternetExplorerOptions options = new InternetExplorerOptions();
            EdgeOptions options = new EdgeOptions();
            DesiredCapabilities capabilities = (DesiredCapabilities)options.ToCapabilities();

            //IWebDriver driver = new RemoteWebDriver(new Uri("https://vm-106.element34.net/wd/hub"), dc);
            IWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), capabilities);

            driver.Navigate().GoToUrl("https://www.lufthansa.com");
            driver.Quit();

        }


    }


    }

