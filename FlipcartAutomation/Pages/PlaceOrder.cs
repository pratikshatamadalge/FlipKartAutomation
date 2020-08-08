using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlipcartAutomation.Pages
{
    class PlaceOrder
    {
        public IWebDriver driver;
        public PlaceOrder(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//div[@id='container']//div//div//div//div//div//div//div//div//form//button")]
        IWebElement placeOrder;
       
        public void PlaceOrderPage()
        {
            placeOrder.Click();
            Thread.Sleep(3000);
        }
    }
}
