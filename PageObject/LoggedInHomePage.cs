using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.PageObject
{
    class LoggedInHomePage
    {
        IWebDriver driver;

        [Obsolete]
        public LoggedInHomePage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }

        //Link to Electronics
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div/span[1]")]
        public IWebElement Lnk_Electronics { get; set; }

        //Link to Mobile MI
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div/div/div[1]/a[2]")]
        public IWebElement Lnk_Mi_Mobile { get; set; }

        public void NavigateToElectronics()
        {
            Console.WriteLine("Navigate to link electronics");
            if (Lnk_Electronics.Displayed == true)
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                Thread.Sleep(5000);
                Actions MouseEvents = new Actions(driver);
                MouseEvents.MoveToElement(Lnk_Electronics).Build().Perform();
            }
            Console.WriteLine("Navigated to link electronics");
        }

        public void NavigateToMiMobile()
        {
            Console.WriteLine("Navigate to  link Mi mobile");
            Thread.Sleep(5000);
            Lnk_Mi_Mobile.Click();
            Console.WriteLine("Clicked on link Mi mobile");
        }
        
    }
}
