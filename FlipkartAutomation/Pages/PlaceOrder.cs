// <copyright file="PlaceOrder.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipcartAutomation.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

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

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Order Summary')]")]
        IWebElement orderSummary;

        public void PlaceOrderPage()
        {
            Thread.Sleep(3000);
            placeOrder.Click();
        }

        public string validatePage()
        {
            return orderSummary.Text;
        }
    }
}
