using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Bibliography;
using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Manoj.Practice.cs
{
    class TakeScreenShot
    {
        [Test]
        public void ScreenShot()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.Url = "https://www.goole.com";
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Func<Screenshot> screendhot = ts.GetScreenshot;
            string title = driver.Title;
            //DateTime datetime = DateTime.Now;
            //string timestamp = datetime.ToString("yyyy MM dd hh mm ss");
            //return timestamp;
            string path = "C:\\Users\\HP\\source\\repos\\Manoj\\Practice.cs\\";
            string filepath = Path.Combine(path, title);
            //screenShot.SaveAsFile(filepath + System.Drawing.Image.ImageFormat.png);
            driver.Quit();

        }
    }
}
