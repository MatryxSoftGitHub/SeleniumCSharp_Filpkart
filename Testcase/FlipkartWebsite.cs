using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit_Flipkart_CS.BaseClass;
using NUnit_Flipkart_CS.PageObject;
using NUnit_Flipkart_CS.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Flipkart_CS.Testcase
{
    [TestFixture]
    class FlipkartWebsite : FlipkartAppState
    {
        [Test]
        [Obsolete]
        public void Test1()
        {
           
            ExcelDataProvider.PopulateInCollection(@"D:\Selenium_C#_PJT\NUnit_Flipkart_CS\NUnit_Flipkart_CS\TestData\FlipkartTestData.xlsx");
            //Login to Filpkart
            test.Log(Status.Info, "Login to Filpkart");
            HomePage homePage = new HomePage(driver);
            homePage.LoginToFlipkart_Step(ExcelDataProvider.ReadData(1, "UserName"), ExcelDataProvider.ReadData(1, "Password"));
            test.Log(Status.Info, "Logged in to Filpkart successsfully");

            //Navigate to Electronics
            test.Log(Status.Info, "Navigate to Electronics");
            LoggedInHomePage loggedInHomePage = new LoggedInHomePage(driver);
            loggedInHomePage.NavigateToElectronics();
            test.Log(Status.Info, "Electronics popup displayed successfully");

            //Navigate to MiMobile
            test.Log(Status.Info, "Navigate to MiMobile");
            loggedInHomePage.NavigateToMiMobile();
            test.Log(Status.Info, "MiMobile page is displayed successfully");

            //Navigate to required mi mobile
            test.Log(Status.Info, "Navigate to required mi mobile");
            MiMobilePage miMobilePage = new MiMobilePage(driver);
            miMobilePage.NaviagteToRequiredMobile(ExcelDataProvider.ReadData(1, "sProductName"));
            test.Log(Status.Info, "Required mi mobile selected successfully");

            //Navigate to Add to cart
            test.Log(Status.Info, "Navigate to Add to cart");
            AddToCartPage requiredMiMobilePage = new AddToCartPage(driver);
            requiredMiMobilePage.NavigateToAddToCart();
            test.Log(Status.Info, "Add to cart page displayed sucessfully");

            //Navigate to Place Order
            test.Log(Status.Info, "Navigate to Place Order");
            PlaceOrderPage placeOrderPage = new PlaceOrderPage(driver);
            placeOrderPage.NavigateToPlaceOrder();
            test.Log(Status.Info, "Place Order page displayed successfully");

            //Add Details to Book the product
            test.Log(Status.Info, "Add Details to Book the product");
            BookingPage addressBookingPage = new BookingPage(driver);
            addressBookingPage.AddDetailsToBookProduct(ExcelDataProvider.ReadData(1,"sName"), ExcelDataProvider.ReadData(1, "sMobileNumber"), ExcelDataProvider.ReadData(1, "sPincode"), ExcelDataProvider.ReadData(1, "sLocality"), ExcelDataProvider.ReadData(1, "sAddress"), ExcelDataProvider.ReadData(1, "sCity"), ExcelDataProvider.ReadData(1, "sLandmark"), ExcelDataProvider.ReadData(1, "sAlternativePhNum"), ExcelDataProvider.ReadData(1, "sCardNum"), ExcelDataProvider.ReadData(1, "sCVV"));
            test.Log(Status.Info, "Details added to Book the product successfully");

            //Remove item from cart
            test.Log(Status.Info, "Remove item from cart");
            requiredMiMobilePage.RemoveProductsFromCart();
            test.Log(Status.Info, "Item removed from the cart successfully");

            //Logout from flipkart
            test.Log(Status.Info, "Logout from flipkart");
            homePage.LogoutFromFlipkart_Step();
            test.Log(Status.Info, "Registered User logout from flipkart successfully");

        }
    }
}
