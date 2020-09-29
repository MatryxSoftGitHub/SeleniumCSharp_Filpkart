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
    class BookingPage
    {
        IWebDriver driver;

        [Obsolete]
        public BookingPage(IWebDriver ldriver)
        {
            this.driver = ldriver;
            PageFactory.InitElements(driver, this);

        }

        //Button Change address
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/button")]
        public IWebElement Btn_ChangeAddress { get; set; }

        //Button Edit
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/div[2]/button")]
        public IWebElement Btn_EditAddress { get; set; }

        
        //Text Field Name
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[2]/div[1]/input")]
        public IWebElement Txt_Name { get; set; }

        
        // Text Field Mobile Number
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[2]/div[2]/input")]
        public IWebElement Txt_MobileMumber { get; set; }

        
        //Text Field Pincode
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[3]/div[1]/input")]
        public IWebElement Txt_Pincode { get; set; }

        //Text Field Locality
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[3]/div[2]/input")]
        public IWebElement Txt_Locality { get; set; }

        //Text Field Address
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[4]/div/div[1]/textarea")]
        public IWebElement Txt_Address { get; set; }

        //Text Field City
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[5]/div[1]/div[1]/input")]
        public IWebElement Txt_City { get; set; }

        //Text Lank Mark
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[6]/div[1]/input")]
        public IWebElement Txt_Lankmark { get; set; }

        //Text Alternative Phone Number
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[6]/div[2]/input")]
        public IWebElement Txt_AlternativePhNum { get; set; }

        //Button Save and Deliver
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[2]/div/div/div/div[1]/label/div[2]/div/form/div/div[8]/button[1]")]
        public IWebElement Btn_SaveAndDeliver { get; set; }

        //Button Continue
        [FindsBy(How = How.XPath, Using = "//*[@id=\"to-payment\"]/button")]
        public IWebElement Btn_Continue { get; set; }

        //Radio Button Credit/Debit card
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[4]/div/div/div[1]/div/label[3]/div[1]")]
        public IWebElement Btn_Credit_DebitCard { get; set; }

        //Text Field Card Number
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[4]/div/div/div[1]/div/label[3]/div[2]/div/div/div[2]/form/div[1]/div/div/input")]
        public IWebElement Txt_CardNum { get; set; }

        //Text Field CVV
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[2]/div/div[1]/div[4]/div/div/div[1]/div/label[3]/div[2]/div/div/div[2]/form/div[3]/div/div/input")]
        public IWebElement Txt_CVV { get; set; }

        //Link Flipkart Mainpage
        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[1]/div/div[2]/div/div/a[1]/img")]
        public IWebElement Lnk_Flipkart_Mainpage { get; set; }

        public void AddDetailsToBookProduct(String sName,String sMobileNumber,String sPincode,String sLocality,String sAddress,String sCity,String sLandmark,String sAlternativePhNum,String sCardNum,String sCVV)
        {
            Console.WriteLine("Enter the address");
            Btn_ChangeAddress.Click();
            Btn_EditAddress.Click();

            Txt_Name.SendKeys(Keys.Control + "a");
            Txt_Name.SendKeys(sName);

            Txt_MobileMumber.SendKeys(Keys.Control + "a");
            Txt_MobileMumber.SendKeys(sMobileNumber);

            Txt_Pincode.SendKeys(Keys.Control + "a");
            Txt_Pincode.SendKeys(sPincode);

            Txt_Locality.SendKeys(Keys.Control + "a");
            Txt_Locality.SendKeys(sLocality);

            Txt_Address.SendKeys(Keys.Control + "a");
            Txt_Address.SendKeys(sAddress);

            Txt_City.SendKeys(Keys.Control + "a");
            Txt_City.SendKeys(sCity);

            Txt_Lankmark.SendKeys(Keys.Control + "a");
            Txt_Lankmark.SendKeys(sLandmark);

            Txt_AlternativePhNum.SendKeys(Keys.Control + "a");
            Txt_AlternativePhNum.SendKeys(sAlternativePhNum);

            Btn_SaveAndDeliver.Click();

            Console.WriteLine("Address added successfully");
            //Thread.Sleep(5000);
            //Btn_Continue.Click();

            //Thread.Sleep(5000);
            //Btn_Credit_DebitCard.Click();

            //Thread.Sleep(5000);
            //Txt_CardNum.SendKeys(Keys.Control + "a");
            //Txt_CardNum.SendKeys(sCardNum);

            //Thread.Sleep(5000);
            //Txt_CVV.SendKeys(Keys.Control + "a");
            //Txt_CVV.SendKeys(sCVV);

            Console.WriteLine("Details added to book the required product succesfully");

            Lnk_Flipkart_Mainpage.Click();


        }


    }
}
