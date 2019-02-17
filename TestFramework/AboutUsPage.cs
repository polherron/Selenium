using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFramework
{
    public class AboutUsPage
    {
        static String pageTitle = "About Us |  Pramerica";
        static string url = "https://www.pramerica.ie/about-us/";
        Browser myBrowser = new Browser();


        //Examples of properties initialised using expression bodies
        IWebElement aboutUsMenuItem => myBrowser.Driver.FindElement(By.Id("menu-item-7547"));
        //IWebElement contactPhoneNumber => myBrowser.Driver.FindElement(By.XPath("//a[contains(@href, 'callto://')]"));
        IWebElement contactPhoneNumber => myBrowser.Driver.FindElement(By.XPath("//div[@id='text-2']/div/p[2]/span[2]/a"));


        public void GoTo()
        {
            myBrowser.Url = url;
        }

        public bool IsAt()
        {
            var title = myBrowser.Title.ToString();
            return myBrowser.Title.Contains(title);
        }

        public bool checkPhoneNumber()
        {
            return contactPhoneNumber.GetAttribute("innerHTML").Contains("+353 (74) 916-7600");
        }
       
      
        public void Close()
        {
            myBrowser.Driver.Close();
        }

    }
}