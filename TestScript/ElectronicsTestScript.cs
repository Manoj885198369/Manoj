//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Manoj.GenericUtility;
//using Manoj.NewFolder;
//using Manoj.Pomclasses;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;

//namespace Manoj.TestScript
//{
//    class ElectronicsTestScript
//    {
//        [Test]
//        public void BuyElectronics()
//        {
//            IWebDriver driver = new ChromeDriver();
//            ReadJsonData js = new ReadJsonData();
//            ReadXlData XL = new ReadXlData();
//            HomePage hp = new HomePage(driver);
//            string browser = js.ReadTheDataFromJson("browser");
//            string Url = js.ReadTheDataFromJson("url");
//            driver.Url = Url;
//            driver.Manage().Window.Maximize();
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
//            string email = js.ReadTheDataFromJson("email");
//            string password = js.ReadTheDataFromJson("password");
//            hp.LoginInToApp(email, password);
//            hp.Electronics.Click();
//            Electronics ele = new Electronics(driver);
            
//            WebDriverUtilities wb = new WebDriverUtilities();
//            wb.SetScrollToElement(driver, Lenovo);
//            ele.Lenovo.Click();

//        }
//    }
//}
