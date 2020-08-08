using FlipcartAutomation.DataProvider;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlipcartAutomation.Pages
{
    class SearchProduct
    {
        public IWebDriver driver;
        public SearchProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        IWebElement searchBox;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")]
        IWebElement product;

        public void SearchProductPage()
        {
            
            searchBox.SendKeys("Iphone"+ Keys.Enter);
            Thread.Sleep(3000);
            product.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
        }
    }
}
