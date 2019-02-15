using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestFramework
{
    public class Browser
    {
        private static IWebDriver driver = new ChromeDriver(@" c:\paul\SeleniumDrivers");

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {
                driver = value;
            }
        }

        public String Title
        {
            get
            {
                return Driver.Title;
            }
        }

        public String Url
        {
            set
            {
                Driver.Url = value;
            }
        }

        public void Close()
        {
            Driver.Close();
        }
    }
}


