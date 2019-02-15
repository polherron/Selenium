
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //FireFoxTest();
            //IEDriver();
            //ChromeDriver();
            using (IWebDriver driver = new ChromeDriver(@" c:\paul\SeleniumDrivers"))
            {
                GoogleImageExample.ClickOnImage(driver);
                Console.ReadLine();
            }

        }

        private static void FireFoxTest()
        {
            //Instantiate a firefox browser remote driiver
            using (IWebDriver driver = new FirefoxDriver())
            {
                //Set the URL property of driver and open the browser at this URL
                driver.Url = "http://www.google.com";
            }
        }

        public static void IEDriver()
        {
            //Instantiate an IE browser  driver
            using (IWebDriver driver = new InternetExplorerDriver(@" c:\paul\SeleniumDrivers"))
            {

                //Set the URL property of driver and open the browser at this URL
                driver.Url = "http://www.google.com";
            }

        }

        public static void ChromeDriver()
        {
            //Instantiate a chrome browser driver
            using (IWebDriver driver = new ChromeDriver(@" c:\paul\SeleniumDrivers"))
            {

                //Set the URL property of driver and open the browser at this URL
                driver.Url = "http://www.google.com";

                //Insert the name of the google search text box
                var searchBox = driver.FindElement(By.Name("q"));

                //now pass a string to the search box
                searchBox.SendKeys("Wild Atlantic Way");
            }
        }
    }
}
