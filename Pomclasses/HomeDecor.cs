using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Manoj.Pomclasses
{
    class HomeDecor
    {
        public HomeDecor(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='sub-category.php?scid=13']")]
        private IWebElement vase;
        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]
        private IWebElement addtocart;
        [FindsBy(How = How.XPath, Using = "//div[@class='basket']")]
        private IWebElement carticon;
        [FindsBy(How = How.XPath, Using = "//a[text()='My Cart']")]
        private IWebElement mycart;
        [FindsBy(How = How.XPath, Using = "//button[@name='ordersubmit']")]
        private IWebElement ordersubmit;
        [FindsBy(How = How.XPath, Using = "//input[@id='exampleInputEmail1']")]
        private IWebElement email;
        [FindsBy(How = How.XPath, Using = "//input[@id='exampleInputPassword1']")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[@name='login']")]
        private IWebElement button;
        [FindsBy(How = How.XPath, Using = "//input[@name='submit']")]
        private IWebElement submit;

        public IWebElement Television { get => vase; set => vase = value; }
        public IWebElement Addtocart { get => addtocart; set => addtocart = value; }
        public IWebElement Carticon { get => carticon; set => carticon = value; }
        public IWebElement Mycart { get => mycart; set => mycart = value; }
        public IWebElement Ordersubmit { get => ordersubmit; set => ordersubmit = value; }
        public IWebElement Email { get => email; set => email = value; }
        public IWebElement Password { get => password; set => password = value; }
        public IWebElement Button { get => button; set => button = value; }
        public IWebElement Submit { get => submit; set => submit = value; }

        public void BuyElectronics(string email1, string pass)
        {
            email.SendKeys(email1);
            password.SendKeys(pass);
            button.Click();
        }
    }
}