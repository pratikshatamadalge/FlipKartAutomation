using FlipcartAutomation.Base;
using FlipcartAutomation.DataProvider;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;

namespace FlipkartAutomation.Utilities
{
    /// <summary>
    /// To store all required functionality 
    /// </summary>
    public class Utility:BaseClass
    {
        /// <summary>
        /// To take screenshot after every test
        /// </summary>
        /// <param name="driver">to control browser</param>
        /// <param name="testStatus">failed or passed test</param>
        /// <returns></returns>
        public static string TakeScreenshot(IWebDriver driver, string testStatus)
        {
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string finalPath = path.Substring(0, path.LastIndexOf("bin")) + "Screenshots\\" + testStatus + ".png";
            string localPath = new Uri(finalPath).LocalPath;
            screenshot.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            return localPath;
        }

        /// <summary>
        /// To send report 
        /// </summary>
        public static void SendEmail()
        {
            JsonReader json = new JsonReader();
            MailMessage mail = new MailMessage();
            string fromEmail = json.email;
            string password = json.password1;
            string toEmail = "pratikshatamadalge21@gmail.com";
            mail.From = new MailAddress(fromEmail);
            mail.Subject = "Please check the attached report";
            mail.To.Add(toEmail);
            mail.Priority = MailPriority.High;
            mail.IsBodyHtml = true;
            mail.Attachments.Add(new Attachment(@"C:\Users\rohit\source\repos\FlipcartAutomation\FlipcartAutomation\ExtentReport\index.html"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(fromEmail, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        public static void InternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "flipkart.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                if (reply != null)
                {
                    Console.Out.WriteLine("Internet connection established");
                }
            }
            catch (Exception e)
            {
                if (e.Message == "An exception occurred during a Ping request.")
                {
                    Console.Out.WriteLine(e.StackTrace);
                    Console.Out.WriteLine(e.Message + " Internet connection not established");
                }
            }
        }
    }
}
