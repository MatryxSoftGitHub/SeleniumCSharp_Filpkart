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
    class MiMobilePage
    {
        IWebDriver driver;

        [Obsolete]
        public MiMobilePage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }

        //Link to select mi mobile
        [FindsBy(How = How.XPath, Using = "//*[@class='_3wU53n']")]
        public IList<IWebElement> List_Lnk_MiMobileName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='_3wU53n']")]
        public IList<IWebElement> Lists { get; set; }

        public void NaviagteToRequiredMobile(String sProductName)
        {
            foreach (IWebElement List in Lists)
            {
                if (List.Text.Equals(sProductName.Trim()))
                {
                    Thread.Sleep(3000);
                    List.Click();
                    System.Threading.Thread.Sleep(2000);
                }
            }
           
        }

    }
}
