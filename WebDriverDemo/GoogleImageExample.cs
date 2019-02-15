using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace WebDriverDemo
{
    class GoogleImageExample
    {
        internal static void ClickOnImage(IWebDriver driver)
        {
            driver.Url = "https://www.google.co.uk/imghp?hl=en&tab=wi";
            var search = driver.FindElement(By.ClassName("gLFyf"));
            search.SendKeys("pluralsight");
            search.Submit();

            var image = driver.FindElement(By.Id(string.Format("S3_A4SCQnV83UM:")));
            image.Click();

            //Explicit Wait
            //In order to get the wait function to run properly, you need to install DotNetSeleniumExtras.WaitHelpers
            //Using nuget, search for DotNetSeleniumExtras.WaitHelpers, import that namespace into your class.  
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(String.Format("rg_ic "))));

            //var image = driver.FindElements(By.ClassName(String.Format("rg_ic ")))[1];
            //image.Click();

            //var image = driver.FindElements(By.CssSelector(String.Format(".rg_ic ")))[1];
            //image.Click();

           // var image = driver.FindElements(By.Id(String.Format(".rg_ic ")))[1];
           // image.Click();

        }
    }
}
