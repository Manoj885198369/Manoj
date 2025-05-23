﻿using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Manoj.GenericUtility
{
    public class WebDriverUtilities
    {
        //private IWebElement element;
        //private object value;
        //private int index;

        //public object Duration { get; private set; }
        //public static object OutputType { get; private set; }
        //public static object FileUtils { get; private set; }

        //public void MaximizeWindowMethod(IWebDriver driver)
        //{
        //    driver.Manage().Window.Maximize();

        //}
        //public void MinimizeWindowMethod(IWebDriver driver)
        //{
        //    driver.Manage().Window.Minimize();
        //}
        //public void WaitForPageLoad(IWebDriver driver, int sec)
        //{
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //}
        //public void WaitForUntilElementGetLoaded(IWebDriver driver, IWebElement element, int sec)
        //{

        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
        //}
        //public void WaitUnitElementToBeClickable(IWebDriver driver, IWebElement element, int sec)
        //{
        //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
        //    wait.Until(ExpectedConditions.ElementToBeClickable(element));
        //}
        //public void DropDown(IWebDriver driver)
        //{
        //    SelectElement sel = new SelectElement(element);
        //    sel.SelectByIndex(index);
        //}
        //public void SelectByValue(IWebDriver driver, string value)
        //{
        //    SelectElement sel = new SelectElement(element);
        //    sel.SelectByValue(value);
        //}
        /**
         * This method is used to select dropdown by using value
         * @param element
         * @param value
         */


        /**
         * This method is used to select dropdown by using visible text
         * @param text
         * @param element
         */
        //public void dropdown(string text, IWebElement element)
        //{
        //    SelectElement sel = new SelectElement(element);
        //    sel.SelectByText(text);
        //}

        //public void mouseHover(IWebDriver driver, IWebElement element)
        //{
        //    Actions act = new Actions(driver);
        //    act.MoveToElement(element).Click().Perform();
        //}

        //public void dragAndDrop(IWebDriver driver, IWebElement src, IWebElement dst)
        //{
        //    Actions act = new Actions(driver);
        //    act.DragAndDrop(src, dst).Perform();
        //}

        //public void doubleClick(IWebDriver driver)
        //{
        //    Actions act = new Actions(driver);
        //    act.DoubleClick().Click().Perform();
        //}

        //public void doubleClickOnElement(IWebDriver driver, IWebElement element)
        //{
        //    Actions act = new Actions(driver);
        //    act.DoubleClick(element).Click().Perform();
        //}

        //public void rightClickOnWebPage(IWebDriver driver)
        //{
        //    Actions act = new Actions(driver);
        //    act.ContextClick().Click().Perform();
        //}

        //public void rightClickOnWebElement(IWebDriver driver, IWebElement element)
        //{
        //    Actions act = new Actions(driver);
        //    act.ContextClick(element).Click().Perform();
        //}

        //public void keyPress(IWebDriver driver, IWebElement ele, string text)
        //{
        //    Actions act = new Actions(driver);
        //    act.SendKeys(ele, text).Perform();
        //}

        //public void keyReleaseEnter(IWebDriver driver)
        //{
        //    Actions action = new Actions(driver);
        //    action.Release().Perform();

        //}

        //public void switchToFrame(WebDriver driver, int index)
        //{
        //    driver.SwitchTo().Frame(index);
        //}

        //public void switchToFrame(WebDriver driver, string nameOrId)
        //{
        //    driver.SwitchTo().Frame(nameOrId);
        //}

        //public void switchToFrame(WebDriver driver, WebElement address)
        //{
        //    driver.SwitchTo().Frame(address);
        //}



        //public void acceptAlert(IWebDriver driver)
        //{
        //    driver.SwitchTo().Alert().Accept();
        //}

        //public void cancelAlert(IWebDriver driver)
        //{
        //    driver.SwitchTo().Alert().Dismiss();
        //}

        //public void scrollBarAction(WebDriver driver)
        //{
        //    IJavaScriptExecutor jse = driver;
        //    jse.ExecuteScript("window.scrollBy(0,500)", "");
        //}

        //public void scrollAction(WebDriver driver, WebElement element)
        //{
        //    IJavaScriptExecutor jse = driver;
        //    //	int y = element.getLocation().getY();
        //    //jse.executeScript("window.scrollBy(0,"+y+")");
        //    //jse.executeScript("argument[0].scrollIntoView()", element);
        //    jse.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        //}

        ////public static String GetScreenshot(IWebDriver driver, String screenshotName)
        ////{
        ////    ITakesScreenshot ts = (ITakesScreenshot)driver;
        ////    File src = ts.GetScreenshot(Type.Base);
        ////    File dst = new(v);
        ////    FileUtils.copyFile(src, dst);
        ////}
        //public void SwitchToWindows(IWebDriver driver, string exptitle)
        //{
        //    System.Collections.ObjectModel.ReadOnlyCollection<string> windows = driver.WindowHandles;
        //    foreach (string win_name in windows)
        //    {
        //        string title = driver.SwitchTo().Window(win_name).Title;
        //        if (title.Equals(exptitle))
        //        {
        //            driver.SwitchTo().Window(win_name);
        //        }
        //    }
        //}
        //public string RetrieveData(IWebDriver driver, IWebElement element)
        //{
        //    string text = element.Text;
        //    return text;
        //}
        //WINDOW related methods

        /**
   * This method is used to maximize window
   * @param driver
   */
        public void MaximizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        /**
   * This method is used to minimize window
   * @param driver
   */
        public void MinimizeWindow(IWebDriver driver)
        {
            driver.Manage().Window.Minimize();
        }

        //Timeouts methods


        /**
        * This method is used to wait until page load
        * @param driver
        * @param sec
        */

        public void WaitForPageLoadOut(IWebDriver driver, int sec)
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(sec);
        }

        /**This method is used for synchornization
        * @param driver
        * @param sec
        */
        public void ImplicitWait(IWebDriver driver, int sec)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
        }



        //WebDriver wait methods



        /**This method is used to wait until url matches
        * @param driver
        * @param sec
        * @param url
        * @author prasadk
        * throw Timeoutexception
        */
        public void SetUrlToBe(IWebDriver driver, int sec, string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.UrlToBe(url));
        }

        /**This method is used to wait until url matches
        * @param driver
        * @param sec
        * @param url
        * @author prasadk
        * throw Timeoutexception
        */
        public void SetUrlMatches(IWebDriver driver, int sec, string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.UrlMatches(url));
        }

        /**This method is used to wait till Url contains mentioned value
        * @param driver
        * @param sec
        * @param url
        * @author prasadk
        * throw Timeoutexception
        */
        public void SetUrlContains(IWebDriver driver, int sec, string url)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.UrlContains(url));
        }

        /**This method is used to wait until title contains the mentioned value
        * @param driver
        * @param sec
        * @param title
        * @author prasadk
        * throw Timeoutexception
        */
        public void SetTitleContains(IWebDriver driver, int sec, string title)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.TitleContains(title));
        }

        /**This method is used to wait until title matches with mentioned title
          * @param driver
          * @param sec
          * @param title
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetTitleIs(IWebDriver driver, int sec, string title)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.TitleIs(title));
        }

        /**This method is used to wait until locator matches with mentioned element
          * @param driver
          * @param sec
          * @param element
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetElementExists(IWebDriver driver, int sec, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementExists(element));
        }

        /**This method is used to wait until visibility of the element
          * @param driver
          * @param sec
          * @param element
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetElementVisible(IWebDriver driver, int sec, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        /**This method is used to wait until element to be clickable
          * @param driver
          * @param sec
          * @param element
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetElementToBeClickable(IWebDriver driver, int sec, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        /**This method is used to wait until element to be selected
          * @param driver
          * @param sec
          * @param element
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetElementToBeSelected(IWebDriver driver, int sec, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.ElementToBeSelected(element));
        }

        /**This method is used to wait until alert is present
          * @param driver
          * @param sec
          * @param element
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetAlertIsPresent(IWebDriver driver, int sec, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        /**This method is used to wait until text is present in the mentioned element.
          * @param driver
          * @param sec
          * @param element
          * @param text
          * @author prasadk
          * throw Timeoutexception
          */
        public void SetTextToBePresentInElement(IWebDriver driver, int sec, IWebElement element, string text)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
        }

        //SelectElement class methods


        /**This method is used to select the option present in the dropdown by using index
         * @param element
         * @param index
         * @author prasadk
         * throw Unsupported Operation exception , NoSuchElement exception
         */
        public void SetSelectByIndex(IWebElement element, int index)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByIndex(index);

        }
        /**This method is used to select the option present in the dropdown by using mention value
         * @param element
         * @param value
         * @author prasadk
         * throw Unsupported Operation exception , NoSuchElement exception
         */
        public void SetSelectByValue(IWebElement element, string value)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByValue(value);
        }
        /**This method is used to select the option present in the dropdown by using mention text value
         * @param element
         * @param text
         * @author prasadk
         * throw Unsupported Operation exception , NoSuchElement exception
         */
        public void SetSelectByText(IWebElement element, string text)
        {
            SelectElement se = new SelectElement(element);
            se.SelectByText(text);
        }
        /**This method is used to deselect the option present in the dropdown by using mention index
        * @param element
        * @param index
        * @author prasadk
        * throw Unsupported Operation exception , NoSuchElement exception
        */
        public void SetDeselectByIndex(IWebElement element, int index)
        {
            SelectElement se = new SelectElement(element);
            se.DeselectByIndex(index);
        }
        /**This method is used to deselect the option present in the dropdown by using mentioned value
       * @param element
       * @param value
       * @author prasadk
       * throw Unsupported Operation exception , NoSuchElement exception
       */
        public void SetDeselectByValue(IWebElement element, string value)
        {
            SelectElement se = new SelectElement(element);
            se.DeselectByValue(value);
        }
        /**This method is used to deselect the option present in the dropdown by using mention text
       * @param element
       * @param text
       * @author prasadk
       * throw Unsupported Operation exception , NoSuchElement exception
       */
        public void SetDeselectByText(IWebElement element, string text)
        {
            SelectElement se = new SelectElement(element);
            se.DeselectByText(text);
        }
        /**This method is used to deselect the all selected option int the multiple select dropdown
        * @param element
        * @author prasadk
        * throw Unsupported Operation exception , NoSuchElement exception
        */
        public void SetDeselectAll(IWebElement element)
        {
            SelectElement se = new SelectElement(element);
            se.DeselectAll();
        }
        /**This method is used to get all the options form the dropdown
        * @param element
        * @param value
        * return Ilist</IWebElement>
        * @author prasadk
        * throw Unsupported Operation exception , NoSuchElement exception
        */
        public IList<IWebElement> GetAllOptions(IWebElement element)
        {
            SelectElement se = new SelectElement(element);
            IList<IWebElement> options = se.Options;
            return options;
        }
        /**This method is used to check dropdown is single select or multiple select dropdown
        * @param element
        * return bool
        * @author prasadk
        * throw Unsupported Operation exception , NoSuchElement exception
        */
        public bool GetIsMultiple(IWebElement element)
        {
            SelectElement se = new SelectElement(element);
            return se.IsMultiple;
        }

        //Actions class methods

        /**This method is used to scroll to mentioned element
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetScrollToElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ScrollToElement(element);
        }
        /**This method is used to perform mouse hover action to mentioned element
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetMoveToElement(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        /**This method is used to perform the mouse click action
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.Click(element).Perform();
        }

        /**This method is used to perform the mouse click and hold to mentioned element
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetClickAndHold(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ClickAndHold(element).Perform();
        }

        /**This method is used to perform the right click action on the mouse
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetContextClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.ContextClick(element).Perform();
        }

        /**This method is used to perform the double click on the mouse
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetDoubleClick(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.DoubleClick(element).Perform();
        }
        /**This method is used to perform drag the element to mentioned location from source location
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetDragAndDrop(IWebDriver driver, IWebElement src, IWebElement drp)
        {
            Actions action = new Actions(driver);
            action.DragAndDrop(src, drp).Perform();
        }
        /**This method is used to send the input into fields
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetSendKeys(IWebDriver driver, string text)
        {
            Actions action = new Actions(driver);
            action.SendKeys(text).Perform();
        }
        /**This method is used to perform the build operation
        * @param driver
        * @param element
        * @author prasadk
        */
        public void SetBuild(IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.Build();
        }
        /**This method is used to press the mentioned key
        * @param driver
        * @param key
        * @param element
        * @author prasadk
        */
        public void SetKeyDown(IWebDriver driver, string key)
        {
            Actions action = new Actions(driver);
            action.KeyDown(key).Perform();
        }
        /**This method is used to release the mentioned key
        * @param driver
        * @param key
        * @param element
        * @author prasadk
        */
        public void SetKeyUP(IWebDriver driver, string key)
        {
            Actions action = new Actions(driver);
            action.KeyUp(key).Perform();
        }
        /**This method is used perform the pause action
        * @param driver
        * @param duration
        * @param element
        * @author prasadk
        */
        public void SetPause(IWebDriver driver, TimeSpan duration)
        {
            Actions action = new Actions(driver);
            action.Pause(duration).Perform();
        }
        /**This method is used to perform the release button
        * @param driver
        * @param element
        * @param element
        * @author prasadk
        */
        public void SetRelease(IWebDriver driver, IWebElement element)
        {
            Actions action = new Actions(driver);
            action.Release(element).Perform();
        }


        //Alert Handle


        /**This method is used to perfom ok on alert popup
        * @param driver
        * @author prasadk
        */
        public void SetAccept(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        /**This method is used to click canel button on alert popup
        * @param driver
        * @author prasadk
        */
        public void SetDismiss(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Dismiss();
        }
        /**This method is used to send the input to alert fields
        * @param driver
        * @author prasadk
        */
        public void SetSendKeysToAlert(IWebDriver driver, string text)
        {
            driver.SwitchTo().Alert().SendKeys(text);
        }
        /**This method is used to capture the text
        * @param driver
        * @author prasadk
        */
        public string GetText(IWebDriver driver, string text)
        {
            return driver.SwitchTo().Alert().Text;
        }

        //Windows Popup and Tabs


        /**This method is used to switch the window by passing window name as a param
        * @param driver
        * @param win_Session_id
        * @author prasadk
        */
        public void SetSwitchToWindow(IWebDriver driver, string win_Session_id)
        {
            driver.SwitchTo().Window(win_Session_id);
        }

        /**This method is used to switch the window based on url matches
        * @param driver
        * @param url
        * @param windown_name
        * @author prasadk
        */
        public void SetSwitchToWindowByURL(IWebDriver driver, string url)
        {
            ReadOnlyCollection<string> allWid = driver.WindowHandles;
            foreach (string wid in allWid)
            {
                driver.SwitchTo().Window(wid);
                if (driver.Url.Contains(url))
                {
                    break;
                }
            }
        }
        /**This method is used to switch the window based on url matches
        * @param driver
        * @param url
        * @param windown_name
        * @author prasadk
        */
        public void SetSwitchToWindowByTitle(IWebDriver driver, string title)
        {
            ReadOnlyCollection<string> allWid = driver.WindowHandles;
            foreach (string wid in allWid)
            {
                driver.SwitchTo().Window(wid);
                if (driver.Title.Contains(title))
                {
                    break;
                }
            }
        }

        //Switch to Frames


        /**This method is used to switch the frame based on index
        * @param driver
        * @param index
        * @author prasadk
        * Throw NoSuchFrame Exception
        */
        public void SSwitchToFrameByIndex(IWebDriver driver, string index)
        {
            driver.SwitchTo().Frame(index);
        }

        /**This method is used to switch the frame based on name of the frame
        * @param driver
        * @param framename
        * @author prasadk
        * Throw NoSuchFrame Exception
        */
        public void SwitchToFrameByName(IWebDriver driver, string name)
        {
            driver.SwitchTo().Frame(name);
        }

        /**This method is used to switch the frame based on name of the frame
       * @param driver
       * @param element
       * @author prasadk
       * Throw NoSuchFrame Exception
       */
        public void SwitchToFrameByElement(IWebDriver driver, IWebElement element)
        {
            driver.SwitchTo().Frame(element);
        }

        //JavaScriptExecutor methods

        public void SendKeyToDisableElement(IWebDriver driver, string text, string id)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("Document.getElementById('" + id + "').value='" + text + "';)");
        }



    }
}









//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using OpenQA.Selenium;
//using SeleniumExtras.WaitHelpers;

//namespace RecruitNest.GenericUtility
//{
//    public class WebDriverUtility
//    {
//        //WINDOW related methods

//        /**
//   * This method is used to maximize window
//   * @param driver
//   */
//        public void MaximizeWindow(IWebDriver driver)
//        {
//            driver.Manage().Window.Maximize();
//        }

//        /**
//   * This method is used to minimize window
//   * @param driver
//   */
//        public void MinimizeWindow(IWebDriver driver)
//        {
//            driver.Manage().Window.Minimize();
//        }

//        //Timeouts methods


//        /**
//        * This method is used to wait until page load
//        * @param driver
//        * @param sec
//        */

//        public void WaitForPageLoadOut(IWebDriver driver, int sec)
//        {
//            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(sec);
//        }

//        /**This method is used for synchornization
//        * @param driver
//        * @param sec
//        */
//        public void ImplicitWait(IWebDriver driver, int sec)
//        {
//            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
//        }



//        //WebDriver wait methods



//        /**This method is used to wait until url matches
//        * @param driver
//        * @param sec
//        * @param url
//        * @author prasadk
//        * throw Timeoutexception
//        */
//        public void SetUrlToBe(IWebDriver driver, int sec, string url)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.UrlToBe(url));
//        }

//        /**This method is used to wait until url matches
//        * @param driver
//        * @param sec
//        * @param url
//        * @author prasadk
//        * throw Timeoutexception
//        */
//        public void SetUrlMatches(IWebDriver driver, int sec, string url)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.UrlMatches(url));
//        }

//        /**This method is used to wait till Url contains mentioned value
//        * @param driver
//        * @param sec
//        * @param url
//        * @author prasadk
//        * throw Timeoutexception
//        */
//        public void SetUrlContains(IWebDriver driver, int sec, string url)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.UrlContains(url));
//        }

//        /**This method is used to wait until title contains the mentioned value
//        * @param driver
//        * @param sec
//        * @param title
//        * @author prasadk
//        * throw Timeoutexception
//        */
//        public void SetTitleContains(IWebDriver driver, int sec, string title)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.TitleContains(title));
//        }

//        /**This method is used to wait until title matches with mentioned title
//          * @param driver
//          * @param sec
//          * @param title
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetTitleIs(IWebDriver driver, int sec, string title)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.TitleIs(title));
//        }

//        /**This method is used to wait until locator matches with mentioned element
//          * @param driver
//          * @param sec
//          * @param element
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetElementExists(IWebDriver driver, int sec, By element)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.ElementExists(element));
//        }

//        /**This method is used to wait until visibility of the element
//          * @param driver
//          * @param sec
//          * @param element
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetElementVisible(IWebDriver driver, int sec, By element)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.ElementIsVisible(element));
//        }

//        /**This method is used to wait until element to be clickable
//          * @param driver
//          * @param sec
//          * @param element
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetElementToBeClickable(IWebDriver driver, int sec, By element)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.ElementToBeClickable(element));
//        }

//        /**This method is used to wait until element to be selected
//          * @param driver
//          * @param sec
//          * @param element
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetElementToBeSelected(IWebDriver driver, int sec, By element)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.ElementToBeSelected(element));
//        }

//        /**This method is used to wait until alert is present
//          * @param driver
//          * @param sec
//          * @param element
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetAlertIsPresent(IWebDriver driver, int sec, By element)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.AlertIsPresent());
//        }

//        /**This method is used to wait until text is present in the mentioned element.
//          * @param driver
//          * @param sec
//          * @param element
//          * @param text
//          * @author prasadk
//          * throw Timeoutexception
//          */
//        public void SetTextToBePresentInElement(IWebDriver driver, int sec, IWebElement element, string text)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
//            wait.Until(ExpectedConditions.TextToBePresentInElement(element, text));
//        }

//        //SelectElement class methods


//        /**This method is used to select the option present in the dropdown by using index
//         * @param element
//         * @param index
//         * @author prasadk
//         * throw Unsupported Operation exception , NoSuchElement exception
//         */
//        public void SetSelectByIndex(IWebElement element, int index)
//        {
//            SelectElement se = new SelectElement(element);
//            se.SelectByIndex(index);

//        }
//        /**This method is used to select the option present in the dropdown by using mention value
//         * @param element
//         * @param value
//         * @author prasadk
//         * throw Unsupported Operation exception , NoSuchElement exception
//         */
//        public void SetSelectByValue(IWebElement element, string value)
//        {
//            SelectElement se = new SelectElement(element);
//            se.SelectByValue(value);
//        }
//        /**This method is used to select the option present in the dropdown by using mention text value
//         * @param element
//         * @param text
//         * @author prasadk
//         * throw Unsupported Operation exception , NoSuchElement exception
//         */
//        public void SetSelectByText(IWebElement element, string text)
//        {
//            SelectElement se = new SelectElement(element);
//            se.SelectByText(text);
//        }
//        /**This method is used to deselect the option present in the dropdown by using mention index
//        * @param element
//        * @param index
//        * @author prasadk
//        * throw Unsupported Operation exception , NoSuchElement exception
//        */
//        public void SetDeselectByIndex(IWebElement element, int index)
//        {
//            SelectElement se = new SelectElement(element);
//            se.DeselectByIndex(index);
//        }
//        /**This method is used to deselect the option present in the dropdown by using mentioned value
//       * @param element
//       * @param value
//       * @author prasadk
//       * throw Unsupported Operation exception , NoSuchElement exception
//       */
//        public void SetDeselectByValue(IWebElement element, string value)
//        {
//            SelectElement se = new SelectElement(element);
//            se.DeselectByValue(value);
//        }
//        /**This method is used to deselect the option present in the dropdown by using mention text
//       * @param element
//       * @param text
//       * @author prasadk
//       * throw Unsupported Operation exception , NoSuchElement exception
//       */
//        public void SetDeselectByText(IWebElement element, string text)
//        {
//            SelectElement se = new SelectElement(element);
//            se.DeselectByText(text);
//        }
//        /**This method is used to deselect the all selected option int the multiple select dropdown
//        * @param element
//        * @author prasadk
//        * throw Unsupported Operation exception , NoSuchElement exception
//        */
//        public void SetDeselectAll(IWebElement element)
//        {
//            SelectElement se = new SelectElement(element);
//            se.DeselectAll();
//        }
//        /**This method is used to get all the options form the dropdown
//        * @param element
//        * @param value
//        * return Ilist</IWebElement>
//        * @author prasadk
//        * throw Unsupported Operation exception , NoSuchElement exception
//        */
//        public IList<IWebElement> GetAllOptions(IWebElement element)
//        {
//            SelectElement se = new SelectElement(element);
//            IList<IWebElement> options = se.Options;
//            return options;
//        }
//        /**This method is used to check dropdown is single select or multiple select dropdown
//        * @param element
//        * return bool
//        * @author prasadk
//        * throw Unsupported Operation exception , NoSuchElement exception
//        */
//        public bool GetIsMultiple(IWebElement element)
//        {
//            SelectElement se = new SelectElement(element);
//            return se.IsMultiple;
//        }

//        //Actions class methods

//        /**This method is used to scroll to mentioned element
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetScrollToElement(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.ScrollToElement(element);
//        }
//        /**This method is used to perform mouse hover action to mentioned element
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetMoveToElement(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.MoveToElement(element).Perform();
//        }

//        /**This method is used to perform the mouse click action
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetClick(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.Click(element).Perform();
//        }

//        /**This method is used to perform the mouse click and hold to mentioned element
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetClickAndHold(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.ClickAndHold(element).Perform();
//        }

//        /**This method is used to perform the right click action on the mouse
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetContextClick(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.ContextClick(element).Perform();
//        }

//        /**This method is used to perform the double click on the mouse
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetDoubleClick(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.DoubleClick(element).Perform();
//        }
//        /**This method is used to perform drag the element to mentioned location from source location
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetDragAndDrop(IWebDriver driver, IWebElement src, IWebElement drp)
//        {
//            Actions action = new Actions(driver);
//            action.DragAndDrop(src, drp).Perform();
//        }
//        /**This method is used to send the input into fields
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetSendKeys(IWebDriver driver, string text)
//        {
//            Actions action = new Actions(driver);
//            action.SendKeys(text).Perform();
//        }
//        /**This method is used to perform the build operation
//        * @param driver
//        * @param element
//        * @author prasadk
//        */
//        public void SetBuild(IWebDriver driver)
//        {
//            Actions action = new Actions(driver);
//            action.Build();
//        }
//        /**This method is used to press the mentioned key
//        * @param driver
//        * @param key
//        * @param element
//        * @author prasadk
//        */
//        public void SetKeyDown(IWebDriver driver, string key)
//        {
//            Actions action = new Actions(driver);
//            action.KeyDown(key).Perform();
//        }
//        /**This method is used to release the mentioned key
//        * @param driver
//        * @param key
//        * @param element
//        * @author prasadk
//        */
//        public void SetKeyUP(IWebDriver driver, string key)
//        {
//            Actions action = new Actions(driver);
//            action.KeyUp(key).Perform();
//        }
//        /**This method is used perform the pause action
//        * @param driver
//        * @param duration
//        * @param element
//        * @author prasadk
//        */
//        public void SetPause(IWebDriver driver, TimeSpan duration)
//        {
//            Actions action = new Actions(driver);
//            action.Pause(duration).Perform();
//        }
//        /**This method is used to perform the release button
//        * @param driver
//        * @param element
//        * @param element
//        * @author prasadk
//        */
//        public void SetRelease(IWebDriver driver, IWebElement element)
//        {
//            Actions action = new Actions(driver);
//            action.Release(element).Perform();
//        }


//        //Alert Handle


//        /**This method is used to perfom ok on alert popup
//        * @param driver
//        * @author prasadk
//        */
//        public void SetAccept(IWebDriver driver)
//        {
//            driver.SwitchTo().Alert().Accept();
//        }
//        /**This method is used to click canel button on alert popup
//        * @param driver
//        * @author prasadk
//        */
//        public void SetDismiss(IWebDriver driver)
//        {
//            driver.SwitchTo().Alert().Dismiss();
//        }
//        /**This method is used to send the input to alert fields
//        * @param driver
//        * @author prasadk
//        */
//        public void SetSendKeysToAlert(IWebDriver driver, string text)
//        {
//            driver.SwitchTo().Alert().SendKeys(text);
//        }
//        /**This method is used to capture the text
//        * @param driver
//        * @author prasadk
//        */
//        public string GetText(IWebDriver driver, string text)
//        {
//            return driver.SwitchTo().Alert().Text;
//        }

//        //Windows Popup and Tabs


//        /**This method is used to switch the window by passing window name as a param
//        * @param driver
//        * @param win_Session_id
//        * @author prasadk
//        */
//        public void SetSwitchToWindow(IWebDriver driver, string win_Session_id)
//        {
//            driver.SwitchTo().Window(win_Session_id);
//        }

//        /**This method is used to switch the window based on url matches
//        * @param driver
//        * @param url
//        * @param windown_name
//        * @author prasadk
//        */
//        public void SetSwitchToWindowByURL(IWebDriver driver, string url)
//        {
//            ReadOnlyCollection<string> allWid = driver.WindowHandles;
//            foreach (string wid in allWid)
//            {
//                driver.SwitchTo().Window(wid);
//                if (driver.Url.Contains(url))
//                {
//                    break;
//                }
//            }
//        }
//        /**This method is used to switch the window based on url matches
//        * @param driver
//        * @param url
//        * @param windown_name
//        * @author prasadk
//        */
//        public void SetSwitchToWindowByTitle(IWebDriver driver, string title)
//        {
//            ReadOnlyCollection<string> allWid = driver.WindowHandles;
//            foreach (string wid in allWid)
//            {
//                driver.SwitchTo().Window(wid);
//                if (driver.Title.Contains(title))
//                {
//                    break;
//                }
//            }
//        }

//        //Switch to Frames


//        /**This method is used to switch the frame based on index
//        * @param driver
//        * @param index
//        * @author prasadk
//        * Throw NoSuchFrame Exception
//        */
//        public void SSwitchToFrameByIndex(IWebDriver driver, string index)
//        {
//            driver.SwitchTo().Frame(index);
//        }

//        /**This method is used to switch the frame based on name of the frame
//        * @param driver
//        * @param framename
//        * @author prasadk
//        * Throw NoSuchFrame Exception
//        */
//        public void SwitchToFrameByName(IWebDriver driver, string name)
//        {
//            driver.SwitchTo().Frame(name);
//        }

//        /**This method is used to switch the frame based on name of the frame
//       * @param driver
//       * @param element
//       * @author prasadk
//       * Throw NoSuchFrame Exception
//       */
//        public void SwitchToFrameByElement(IWebDriver driver, IWebElement element)
//        {
//            driver.SwitchTo().Frame(element);
//        }

//        //JavaScriptExecutor methods

//        public void SendKeyToDisableElement(IWebDriver driver, string text, string id)
//        {
//            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//            js.ExecuteScript("Document.getElementById('" + id + "').value='" + text + "';)");
//        }

//    }
//}
