using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using TestFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace FrameworkForJoe
{
    [TestFixture]
    public class SampleTest
    {
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;
        private static ExtentTest test;
        private Browser driver;

        [OneTimeSetUp]
        public void SetupReporting()
        {

            //To obtain the current solution path/project path

            var pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            var actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            var projectPath = new Uri(actualPath).LocalPath;



            //Append the html report file to current project path

            var reportPath = projectPath + "Reports\\TestRunReport.html";



            htmlReporter = new ExtentHtmlReporter(reportPath);

           /* htmlReporter.Configuration().Theme = Theme.Dark;

            htmlReporter.Configuration().DocumentTitle = "JoesDocument";

            htmlReporter.Configuration().ReportName = "JoesReport";*/

            htmlReporter.LoadConfig(projectPath + "Extent-Config.xml"); //Get the config.xml file 



            /*htmlReporter.Configuration().JS = "$('.brand-logo').text('test image').prepend('<img src=@"file:///D:\Users\jloyzaga\Documents\FrameworkForJoe\FrameworkForJoe\Capgemini_logo_high_res-smaller-2.jpg"> ')";*/
            /*htmlReporter.Configuration().JS = "$('.brand-logo').text('').append('<img src=D:\\Users\\jloyzaga\\Documents\\FrameworkForJoe\\FrameworkForJoe\\Capgemini_logo_high_res-smaller-2.jpg>')";*/
            extent = new ExtentReports();

            extent.AttachReporter(htmlReporter);
        }

        [SetUp]
        public void InitBrowser()
        {
            driver = new Browser();
            driver.Driver.Manage().Window.Maximize();
        }

        [Test]
        public void PassingTest()
        {
            test = extent.CreateTest("Passing test");

            driver.Driver.Navigate().GoToUrl("http://www.google.com");

            try
            {
                Assert.IsTrue(true);
                test.Pass("Assertion passed");
            }
            catch (AssertionException)
            {
                test.Fail("Assertion failed");
                throw;
            }
        }

        [Test]
        public void FailingTest()
        {
            test = extent.CreateTest("Failing test");

            driver.Driver.Navigate().GoToUrl("http://www.yahoo.com");

            try
            {
                Assert.IsTrue(false);
                test.Pass("Assertion passed");
            }
            catch (AssertionException)
            {
                test.Fail("Assertion failed");
                throw;
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Driver.Quit();
        }

        [OneTimeTearDown]
        public void GenerateReport()
        {
            extent.Flush();
        }
    }
}

