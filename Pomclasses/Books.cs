using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LanguageExt.TypeClasses;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Manoj.Pomclasses
{
   public class BooksPage
    {
        public BooksPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@href='sub-category.php?scid=8']")]
        private IWebElement comics;
        [FindsBy(How = How.XPath, Using = " (//h3[@class='name'])[5]")]
        private IWebElement book ;
        [FindsBy(How = How.XPath, Using = "//button[text()='Add to cart']")]
        private IWebElement addtocart;
        [FindsBy(How = How.XPath, Using = "//div[@class='basket']")]
        private IWebElement carticon;
        [FindsBy(How = How.XPath, Using = "//a[text()='My Cart']")]
        private IWebElement mycart;
        [FindsBy(How = How.XPath, Using = "//button[@name='ordersubmit']")]
        private IWebElement ordersubmit;
        [FindsBy(How = How.Id, Using = "//input[@id='exampleInputEmail1']")]
        private IWebElement email;
        [FindsBy(How = How.XPath, Using = "//input[@id='exampleInputPassword1']")]
        private IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[@name='login']")]
        private IWebElement button;
        [FindsBy(How = How.XPath, Using = "//input[@name='submit']")]
        private IWebElement submit;
        [FindsBy(How = How.XPath, Using = "//a[text()=' Books']")]
        private IWebElement booksLocator;

        public IWebElement Comics { get => comics; set => comics = value; }
        public IWebElement Addtocart { get => addtocart; set => addtocart = value; }
        public IWebElement Carticon { get => carticon; set => carticon = value; }
        public IWebElement Mycart { get => mycart; set => mycart = value; }
        public IWebElement Ordersubmit { get => ordersubmit; set => ordersubmit = value; }
        public IWebElement Email { get => email; set => email = value; }
        public IWebElement Password { get => password; set => password = value; }
        public IWebElement Button { get => button; set => button = value; }
        public IWebElement BooksLocator { get => booksLocator; set => booksLocator = value; }
        public IWebElement Book { get => book; set => book = value; }
        public IWebElement Submit { get => submit; set => submit = value; }

        public void BuyBooks(string email1, string pass)
        {
            email.SendKeys(email1);
            password.SendKeys(pass);
            button.Click();
            
        }
        public void ClickOnBooks() 
        {
            book.Click();
            Submit.Click();
        }
        
       

    }
}
