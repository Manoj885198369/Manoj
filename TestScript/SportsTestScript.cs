using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manoj.NewFolder;
using Manoj.Pomclasses;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Manoj.TestScript
{
    class SportsTestScript
    {
        [Test]
        public void BuyAShoes()
        {
            IWebDriver driver = new ChromeDriver();
            ReadJsonData js = new ReadJsonData();
            ReadXlData XL = new ReadXlData();
          //  LoginPage lp = new LoginPage(driver);
            string browser = js.ReadTheDataFromJson("browser");
            string Url = js.ReadTheDataFromJson("url");
            driver.Url = Url;
            string email = js.ReadTheDataFromJson("email");
            string password = js.ReadTheDataFromJson("password");
            //lp.LoginToApp(email, password);
            HomePage hp = new HomePage(driver);
            Sports sp = new Sports(driver);
        }
    }
}
