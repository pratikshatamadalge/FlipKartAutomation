// <copyright file="BaseClass.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace FlipcartAutomation.Base
{
    using System;
    using System.Net.NetworkInformation;
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
        private static readonly log4net.ILog log =log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [OneTimeSetUp]
        public void Initialization()
        {
            ChromeOptions options = new ChromeOptions();
            log.Info("Chromeoptions instance created and added arguments to it");
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
                Ping myPing = new Ping();
                String host = "flipkart.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if(reply!=null)
                {
                    Console.Out.WriteLine("Internet connection established");
                }

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
                log.Error("error: "+e);
                if (e.Message == "An exception occurred during a Ping request.")
                {
                    Console.Out.WriteLine(e.StackTrace);
                    Console.Out.WriteLine(e.Message + " Internet connection not established");
                }
                else
                {
                    Console.Out.WriteLine(e.StackTrace);
                    Console.Out.WriteLine(e.Message);
                }
            }

            Thread.Sleep(5000);
            extent.Flush();
        }
    }
}
