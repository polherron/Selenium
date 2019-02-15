using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;
using System.Diagnostics;
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CanGoToHomePage()
        {
            Pages.HomePage.GoTo();
            Assert.IsTrue(Pages.HomePage.IsAt());
        }

        [TestMethod]
        public void CanGoToContactUs()
        {
            Pages.HomePage.GoTo();
            Pages.HomePage.GoToConactUsPage();
            Assert.IsTrue(Pages.HomePage.IsAtContactUsPage());
        }
        
        //Closes the browser
        [ClassCleanup]
        public static void CleanUp()
        {
           Pages.Browser.Close();

        }
    }
}


