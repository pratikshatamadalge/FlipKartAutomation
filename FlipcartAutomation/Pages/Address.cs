using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlipcartAutomation.Pages
{
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


        public void AddressPage()
        {
            logo.Click();
            Thread.Sleep(4000);
        }
    }
}
