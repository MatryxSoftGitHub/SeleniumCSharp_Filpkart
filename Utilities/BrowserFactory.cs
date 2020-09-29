using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.Utilities
{
    class BrowserFactory
    {
        public static IWebDriver OnStart(IWebDriver driver, String BrowserName, String AppURL)
        {
            switch (BrowserName)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;

                case "Firefox":
                    driver = new FirefoxDriver();
                    break;

                case "IE":
                    driver = new InternetExplorerDriver();
                    break;

                default:
                    Console.WriteLine("We do not support this browser");
                    break;
            }

            driver.Url = AppURL;
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
