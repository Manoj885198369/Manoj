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

namespace Manoj.TestScript
{
    class Login
    {
        [Test]
        public void Home()
        {
            IWebDriver driver = new ChromeDriver();
             
            HomePage homePage = new HomePage(driver);
             
            ReadJsonData js = new ReadJsonData();
            string browser = js.ReadTheDataFromJson("browser");
           string Url= js.ReadTheDataFromJson("url");
            string email = js.ReadTheDataFromJson("email");
            string password = js.ReadTheDataFromJson("password");
            
            driver.Url = Url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
           // driver.FindElement(By.XPath("//a[@href='login.php']")).Click();
            homePage.LoginInToApp(email, password);
            homePage.Books.Click();

        }
    }
}
