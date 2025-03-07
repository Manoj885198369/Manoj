using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Manoj.Pomclasses
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='login.php']")]
        private IWebElement login;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Books']")]
        [FindsBy(How = How.XPath, Using = "//li[@class='dropdown yamm']//a[@href='category.php?cid=3']")]
        private IWebElement books;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Electronics']")]
        private IWebElement electronics;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Fashion']")]
        private IWebElement fashion;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Home Decor']")]
        private IWebElement homedecor;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Jewelry']")]
        private IWebElement jewelery;
        [FindsBy(How = How.XPath, Using = "//a[text()=' sports']")]
        private IWebElement sports;
        [FindsBy(How = How.Id, Using = "exampleInputEmail1")]
        private IWebElement email;
        [FindsBy(How = How.Id, Using = "exampleInputPassword1")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[@name='login']")]
        private IWebElement button;


        public IWebElement Login { get => login; set => login = value; }
        public IWebElement Books { get => books; set => books = value; }
        public IWebElement Electronics { get => electronics; set => electronics = value; }
        public IWebElement Homedecor { get => homedecor; set => homedecor = value; }
        public IWebElement Jewelery { get => jewelery; set => jewelery = value; }
        public IWebElement Sports { get => sports; set => sports = value; }
        public IWebElement Email { get => email; set => email = value; }
        public IWebElement Password { get => password; set => password = value; }
        public IWebElement Button { get => button; set => button = value; }

        public void LoginInToApp(string email1, string pass)
        {
            Login.Click();
            Email.SendKeys(email1);
            Password.SendKeys(pass+Keys.Enter);
            
        }
        //public void ClickOnLogin()
        //{
        //    Login.Click();
        //    Books.Click();
        //    Electronics.Click();
        //    Homedecor.Click();
        //    Jewelery.Click();
        //    Sports.Click();

        //}

    }
}
