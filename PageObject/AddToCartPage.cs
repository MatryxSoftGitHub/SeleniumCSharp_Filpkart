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
    class AddToCartPage
    {
        IWebDriver driver;

        [Obsolete]
        public AddToCartPage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }
        
        //Botton add to cart
        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _2Npkh4 _2MWPVK']")]
        public IWebElement Btn_AddToCart { get; set; }

        // Cart link 
        [FindsBy(How = How.XPath, Using = "//a[@class='_3ko_Ud']//span[contains(text(),'Cart')]")]
        public IWebElement Lnk_Cart { get; set; }

        // Remove product from the cart 
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Remove')]")]
        public IList<IWebElement> Lnk_RemoveProducts { get; set; }

        // RemoveButton in cart 
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Remove')]")]
        public IWebElement Btn_RemoveInCart { get; set; }

        // Remove button in Remove item block from the cart 
        [FindsBy(How = How.XPath, Using = "//div[@class='gdUKd9 _3Z4XMp _2nQDKB']")]
        public IWebElement Btn_RemoveInBlk { get; set; }

        // Remove item block from the cart 
        [FindsBy(How = How.XPath, Using = "//*[@class='_3hgEev _3QHbp5']")]
        public IWebElement Blk_RemoveItem { get; set; }

        //Link Flipkart Mainpage
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[1]/div/div[2]/div/div/a[1]/img")]
        public IWebElement Lnk_Flipkart_Mainpage { get; set; }




        public void NavigateToAddToCart()
        {
            List<String> tabs = new List<String>(driver.WindowHandles);
            if (tabs.Count() > 1)
            {
                driver.SwitchTo().Window(tabs[0]);
                driver.Close();
                driver.SwitchTo().Window(tabs[1]);
            }

            Console.WriteLine("Navigate to add to cart");
            Btn_AddToCart.Click();
            Console.WriteLine("Clicked on add to cart");
        }

        public void RemoveProductsFromCart()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Actions actions = new Actions(driver);
            Console.WriteLine("Remove product from the cart");
            Thread.Sleep(1000); 
            Lnk_Cart.Click(); 
 
            int iNumOfProducts = Lnk_RemoveProducts.Count();
            //System.out.println(iNumOfProducts); 

            for (int i = 0; i <iNumOfProducts; i++)
            {
                Thread.Sleep(3000);
                actions.MoveToElement(Btn_RemoveInCart).Perform();
                Thread.Sleep(2000);
                Btn_RemoveInCart.Click();
                if (Blk_RemoveItem.Displayed == true)
                {
                    actions.MoveToElement(Btn_RemoveInBlk).Perform();
                    Thread.Sleep(2000);
                    Btn_RemoveInBlk.Click();
                    //System.out.println("Product removed successfully"); 
                }
            }

            //Lnk_Flipkart_Mainpage.Click();
        }
    }

}
