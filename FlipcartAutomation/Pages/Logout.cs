using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FlipcartAutomation.Pages
{
    public class Logout
    {
        public IWebDriver driver;
        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        IWebElement myAccount;
        

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div[3]/div[1]/div[1]/div[1]")]
        IWebElement MyAccountDropdown;

        [FindsBy(How = How.XPath, Using = "//li[10]//a[1]")]
        IWebElement logout;
        //body//div[@id='container']//div//div//div//div//li[10]//a[1]
        
        public void LogoutPage()
        {
            Thread.Sleep(3000);
            myAccount.Click();
            Thread.Sleep(4000);
            MyAccountDropdown.Click();
            Thread.Sleep(5000);
            logout.Click();
            Thread.Sleep(5000);
        }
    }
}