using FlipcartAutomation.Base;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace FlipkartAutomation.Screenshot
{
    public class TakeScreenshot:BaseClass
    {
        public const string path = "C:\\Users\\rohit\\source\\repos\\FlipcartAutomation\\FlipcartAutomation\\Screenshot";
        public void Screenshot(string methodName)
        {
            StringBuilder TimeAndDate = new StringBuilder(DateTime.Now.ToString());
            TimeAndDate.Replace("/", "_");
            TimeAndDate.Replace(":", "_");
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(path+methodName+".png"+TimeAndDate, ScreenshotImageFormat.Png);
        }
    }
}
