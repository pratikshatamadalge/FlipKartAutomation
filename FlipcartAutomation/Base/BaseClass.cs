using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlipcartAutomation.Base
{
    public class BaseClass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Initialization()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito", "--start-maximized", "--disable-notifications");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.flipkart.com/";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
