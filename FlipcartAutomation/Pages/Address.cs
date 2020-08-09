// <copyright file="Address.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipcartAutomation.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    class Address
    {
        public IWebDriver driver;

        public Address(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        /*[FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        IWebElement name;
        [FindsBy(How = How.XPath, Using = "//input[@name='phone']")]
        IWebElement mobileNo;
        [FindsBy(How = How.Name, Using = "pincode")]
        IWebElement pinCode;
        [FindsBy(How = How.Name, Using = "addressLine2")]
        IWebElement locality;
        [FindsBy(How = How.Name, Using = "addressLine1")]
        IWebElement address;
        [FindsBy(How = How.Name, Using = "city")]
        IWebElement city;
        [FindsBy(How = How.Name, Using = "state")]
        IWebElement state;
        [FindsBy(How = How.XPath, Using = "//label//label[1]//div[1]")]
        IWebElement addressType;
        [FindsBy(How = How.XPath, Using = "//div[8]//button[1]")]
        IWebElement saveAndDeliver;
        [FindsBy(How = How.ClassName, Using = "_35lzyU")]
        IWebElement email;
        [FindsBy(How = How.ClassName, Using = "_2AkmmA _2Q4i61 _7UHT_c")]
        IWebElement continueBtn;*/
        [FindsBy(How = How.XPath, Using = "//a[1]//img[1]")]
        IWebElement logo;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Order Summary')]")]
        IWebElement orderSummary;

        public void AddressPage()
        {
            Thread.Sleep(3000);
            logo.Click();
        }

        public string validatePage()
        {
            return orderSummary.Text;
        }
    }
}
