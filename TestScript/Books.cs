using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manoj.GenericUtility;
using Manoj.NewFolder;
using Manoj.Pomclasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Manoj.TestScript
{
    class BookTestScript
    {
        [Test]
        public void BuyABook()
        {
            IWebDriver driver = new ChromeDriver();
            ReadJsonData js = new ReadJsonData();
            ReadXlData XL = new ReadXlData();
            HomePage hp = new HomePage(driver);
            string browser = js.ReadTheDataFromJson("browser");
            string Url = js.ReadTheDataFromJson("url");
            driver.Url = Url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string email = js.ReadTheDataFromJson("email");
            string password = js.ReadTheDataFromJson("password");
            hp.LoginInToApp(email, password);
            hp.Books.Click();
            BooksPage b = new BooksPage(driver);
            WebDriverUtilities web = new WebDriverUtilities();
            IJavaScriptExecutor jsc = (IJavaScriptExecutor)driver;
            jsc.ExecuteScript("arguments[0].scrollIntoView(true);", b.Book);
            b.Book.Click();
           
            b.Addtocart.Click();
           
            b.Submit.Click();
            



        }
    }
}
