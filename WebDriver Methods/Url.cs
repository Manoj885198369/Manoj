using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Manoj.WebDriver_Methods
{
    class Url
    {
        [Test]
        public void BrowserLaunch()
    {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://amazon.in/";
            driver.Quit();

    }

    
    }
}
