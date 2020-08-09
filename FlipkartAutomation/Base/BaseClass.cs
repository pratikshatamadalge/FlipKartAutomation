// <copyright file="BaseClass.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace FlipcartAutomation.Base
{
    using System;
    using System.Threading;
    using AventStack.ExtentReports;
    using AventStack.ExtentReports.MarkupUtils;
    using FlipkartAutomation.ExtentReport;
    using FlipkartAutomation.Utilities;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;

    public class BaseClass
    {
        public IWebDriver driver;
        public const string path = "C:\\Users\\rohit\\source\\repos\\FlipcartAutomation\\FlipcartAutomation\\Screenshot";
        public static ExtentReports extent = ReportManager.GetInstance();
        public static ExtentTest test;

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

        [TearDown]
        public void close()
        {
            try
            {
                test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
                if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
                {
                    string path = Utility.TakeScreenshot(driver, TestContext.CurrentContext.Test.Name);
                    test.Log(Status.Fail, "Test Failed");
                    test.AddScreenCaptureFromPath(path);
                    test.Fail(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Red));
                }
                else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
                {
                    test.Log(Status.Pass, "Test Sucessful");
                    test.Pass(MarkupHelper.CreateLabel(TestContext.CurrentContext.Test.Name, ExtentColor.Green));
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            Thread.Sleep(5000);
            extent.Flush();
        }
    }
}
