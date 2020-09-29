using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.PageObject
{
    class PlaceOrderPage
    {
        IWebDriver driver;

        [Obsolete]
        public PlaceOrderPage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }

        //Button Place Order
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Place Order')]")]
        public IWebElement Btn_PlaceOrder { get; set; }

        public void NavigateToPlaceOrder()
        {
            Console.WriteLine("Navigate to place Order");
            Thread.Sleep(5000);
            Btn_PlaceOrder.Click();
            Console.WriteLine("Clicked on Place Order");
        }
    }
}
