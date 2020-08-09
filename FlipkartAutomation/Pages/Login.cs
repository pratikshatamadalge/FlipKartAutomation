// <copyright file="Login.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipcartAutomation.Pages
{
    using System.Threading;
    using FlipcartAutomation.DataProvider;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Login
    {
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div//form//div[1]//input[1]")]
        IWebElement mobileNo;

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div[2]//input[1]")]
        IWebElement password;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//form//div//button//span[contains(text(),'Login')]")]
        IWebElement loginBtn;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        IWebElement myAccount;

        public void LoginPage()
        {
            JsonReader json = new JsonReader();
            mobileNo.SendKeys(json.mobileNo);
            password.SendKeys(json.password);
            loginBtn.Click();
        }

        public string validatePage()
        {
            Thread.Sleep(5000);
            return myAccount.Text;
        }
    }
}
