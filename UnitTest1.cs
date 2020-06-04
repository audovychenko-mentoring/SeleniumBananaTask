using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace SeleniumBananaTask
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverFF;

        [AssemblyInitialize]
        public static void SetUp(TestContext context)
        {            
            driverFF = new FirefoxDriver(@"C:\Program Files\WebDrivers");
        }

        [TestMethod]
        public void BananaSongTest()
        {
            driverFF.Navigate().GoToUrl("https://www.google.com/");
        }
    }
}
