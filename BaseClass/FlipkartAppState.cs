using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit_Flipkart_CS.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.BaseClass
{
    [TestFixture]
    public class FlipkartAppState
    {
        public IWebDriver driver;
        public ExtentReports extent;
        public ExtentTest test;

        [SetUp]
        public void OnStart()
        {
            test = extent.CreateTest("FlipkartWebSite").Info("Testcase started");

            test.Log(Status.Info, "Browser is launched");

            //Navigate to naukri website

            driver = BrowserFactory.OnStart(driver, "Chrome", "https://www.flipkart.com/");

            //Navigate to Flipkart website

            Console.WriteLine("Filpkart Website home page is displayed!");

            driver.Manage().Window.Maximize();

        }

        public void SendAnEmailNow(string sSubject, string sContentBody)
        {
            //Sender's email, Sender's password, To/Receiver's email, Subject, Body, cc, Attachment
            MailMessage mail = new MailMessage();
            string sFromMail = "pavanigk1293@gmail.com";
            string sPassword = DecodedPassword("VmlkeWEyNzEy");
            //string sPassword = "M@tryxDileep@0628";
            string sToMail = "pavani@matryxsoft.com";

            mail.From = new MailAddress(sFromMail);
            mail.To.Add(sToMail);
            mail.Subject = sSubject;
            mail.Body = sContentBody;
            mail.IsBodyHtml = true;
            ///To obtain the current solution path/project path

            //string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            //string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            //string projectPath = new Uri(actualPath).LocalPath;

            //Append the html report file to current project path
            //string reportPath = projectPath + "Reports\\FlipkartWebsiteReport.html";
            //mail.Attachments.Add(new Attachment(reportPath));
            mail.Attachments.Add(new Attachment(@"D:\Selenium_C#_PJT\NUnit_Flipkart_CS\NUnit_Flipkart_CS\Reports\FlipkartWebsiteReport.html"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            //SmtpClient smtp = new SmtpClient("sg2plcpnl0104.prod.sin2.secureserver.net", 465);
            smtp.Credentials = new NetworkCredential(sFromMail, sPassword);
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }

        //Password Encoding and Decoding
        public string DecodedPassword(string sPassword)
        {
            var encodedpasswordInBytes = Convert.FromBase64String(sPassword);
            string decodedPassword = Encoding.UTF8.GetString(encodedpasswordInBytes);
            return decodedPassword;
        }

        [OneTimeSetUp]
            public void ExtentStart()
            {
                try
                {
                    extent = new ExtentReports();

                    //To obtain the current solution path/project path

                    //string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
                    //string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
                    //string projectPath = new Uri(actualPath).LocalPath;

                    //Append the html report file to current project path
                    //string reportPath = projectPath + "Reports\\FlipkartWebsiteReport.html";

                    //var htmlReporter = new ExtentHtmlReporter(reportPath);
                    var htmlReporter = new ExtentHtmlReporter(@"D:\Selenium_C#_PJT\NUnit_Flipkart_CS\NUnit_Flipkart_CS\Reports\FlipkartWebsiteReport.html");
                    extent.AttachReporter(htmlReporter);
                    extent.AddSystemInfo("Operating System", "Windows 10");
                    extent.AddSystemInfo("HostName", "Pavani G K");
                    extent.AddSystemInfo("Environment", "QA");
                    extent.AddSystemInfo("Author", "Pavani");
                    extent.AddSystemInfo("Browser", "Chrome");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }
        [OneTimeTearDown]
          
        public void SendEmail()
        {
            SendAnEmailNow("Flipkart Website Report", "PFA of selenium C# report");

        }

        

        [TearDown]
        public void OnFinish()
        {
            
            extent.Flush();
            driver.Quit();
            test.Log(Status.Info, "Browser is closed");
            test.Log(Status.Pass, "Testcase is passed");
        }
    }
}
