using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static AboutUsPage AboutUs
        {
            get
            {
                var aboutUsPage = new AboutUsPage();
                return aboutUsPage;
            }
        }

        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                return homePage;
            }
        }

        public static LoggedInPage LoggedInPage
        {
            get
            {
                var loggedInPage = new LoggedInPage();
                return loggedInPage;
            }

        }

        public static Browser Browser
        {
            get
            {
                var myBrowser = new Browser();
                return myBrowser;
            }

        }
    }
}


