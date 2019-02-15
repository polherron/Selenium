using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class HomePageElements
    {
        Browser myBrowser = new Browser();
        IWebElement aboutUsMenuItem => myBrowser.Driver.FindElement(By.Id("menu-item-7547"));
        IWebElement userIdControl => myBrowser.Driver.FindElement(By.Id("usr"));
        IWebElement passwordControl => myBrowser.Driver.FindElement(By.Id("pwd"));
        IWebElement cookieOkButton => myBrowser.Driver.FindElement(By.Id("cookie_action_close_header"));

       // IWebElement cookieOkButton => myBrowser.Driver.FindElement(By.;
    }
}
