using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class HomePage
    {

        static String pageTitle = "Pramerica";
        static string url = "https://www.pramerica.ie/";
        Browser myBrowser = new Browser();


        //Examples of properties initialised using
        IWebElement aboutUsMenuItem => myBrowser.Driver.FindElement(By.Id("menu-item-7547")); 
        IWebElement userIdControl => myBrowser.Driver.FindElement(By.Id("usr"));
        IWebElement passwordControl => myBrowser.Driver.FindElement(By.Id("pwd"));
        IWebElement cookieOkButton => myBrowser.Driver.FindElement(By.Id("cookie_action_close_header"));

        public void GoTo()
        {
            myBrowser.Url = url;
        }

        public bool IsAt()
        {
            var title = myBrowser.Title.ToString();
            Console.WriteLine(title);
            return myBrowser.Title.Contains(pageTitle);
        }

        public void GoToConactUsPage()
        {
            //Clicking the cookie notice.
            //This uses the cookieOkButton By type.
            //Note that we still need to use the find element here.
            //myBrowser.Driver.FindElement(cookieOkButton).Click();
            
            cookieOkButton.Click();
            var wait = new WebDriverWait(myBrowser.Driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(aboutUsMenuItem)).Click();

        }

        public bool IsAtContactUsPage()
        {
            var aboutUsPageTitle = "Contact Us | Pramerica";
            return myBrowser.Title.Contains(aboutUsPageTitle);
        }

        public void Close()
        {
            myBrowser.Driver.Close();
        }

    }
}
