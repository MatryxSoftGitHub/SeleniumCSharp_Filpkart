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
    class HomePage
    {
        IWebDriver driver;

        [Obsolete]
        public HomePage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }
        //Username
        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        public IWebElement sTxt_Username { get; set; }

        // Password
        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        public IWebElement Txt_Password { get; set; }

        // Sign in Button
        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']")]
        public IWebElement Btn_LogIn { get; set; }

        // Login Link button to login 
        [FindsBy(How = How.XPath, Using = "//a[@class='_3Ep39l']")]
        public IWebElement Lnk_LogIn { get; set; }

        // MyAccount Link to get option 
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        public IWebElement Lnk_MyAccount { get; set; }

        // Logout Link button to logout 
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Logout')]")]
        public IWebElement Lnk_Logout { get; set; }

        // Search box Text field 
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
        public IWebElement sTxt_SearchBox { get; set; }

        //Link Flipkart Mainpage
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[1]/div/div[2]/div/div/a[1]/img")]
        public IWebElement Lnk_Flipkart_Mainpage { get; set; }




        public void NavigateToLoginPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
           
        }


        public void LoginToFlipkart_Step(String UserName, String Password)
        {


            Console.WriteLine("Login to Flipkart Application"); 
 
          if (sTxt_Username.Displayed == true) {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                sTxt_Username.SendKeys(UserName); 
               Txt_Password.SendKeys(Password); 
               Btn_LogIn.Click(); 
          } else { 
               Lnk_LogIn.Click(); 
               Thread.Sleep(3000);
                Console.WriteLine("Login to Flipkart Application");
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                sTxt_Username.SendKeys(UserName); 
               Txt_Password.SendKeys(Password); 
               Btn_LogIn.Click(); 
          }
            Console.WriteLine("Login to Flipkart Application is successfull"); 
 
     } 
 
     public void LogoutFromFlipkart_Step() 
{
            Console.WriteLine("Logout for Flipkart Application"); 
          if (Lnk_MyAccount.Displayed == true) {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                Thread.Sleep(5000);
                Actions actions = new Actions(driver);
                actions.MoveToElement(Lnk_MyAccount).Perform();
                actions.MoveToElement(Lnk_Logout).Perform();
                Lnk_Logout.Click();
            }
            else
            {
                Thread.Sleep(5000);
                Lnk_Flipkart_Mainpage.Click();
                Thread.Sleep(5000);
                Actions actions = new Actions(driver);
                actions.MoveToElement(Lnk_MyAccount).Perform();
                actions.MoveToElement(Lnk_Logout).Perform();
                Lnk_Logout.Click();

            }
            Console.WriteLine("Logout from Flipkart Application is successfull");

}

public void SearchForAProduct_Step(String sProductName) 
{
            Console.WriteLine("Search a product in Flipkart Application");
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
    Thread.Sleep(5000); 
 
          if (sTxt_SearchBox.Displayed == true) {
        sTxt_SearchBox.SendKeys(Keys.Control + "a");
        sTxt_SearchBox.SendKeys(sProductName);
        sTxt_SearchBox.SendKeys(Keys.Enter);
    }
    Thread.Sleep(5000);

}

    }
}








