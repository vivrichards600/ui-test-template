using System;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace ui_test_template
{
    public class BasePage
    {
        public IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown() => driver.Quit();

        ///// <summary>
        ///// Check if the current page title is the one that is expected
        ///// </summary>
        ///// <param name="pageTitle">The expected page title</param>
        //public void OnPage(string pageTitle)
        //{
        //    if (driver.Title != pageTitle) throw PageNotFoundException(pageTitle);
        //}

        ///// <summary>
        ///// Throws an exception if the current page title isn't
        ///// the page title that was expected
        ///// </summary>
        ///// <param name="pageTitle">The expected page title from driver.Title</param>
        ///// <returns>An PageNotFoundException if page titles do not match</returns>
        //private Exception PageNotFoundException(string pageTitle)
        //{
        //    throw new Exception($"Expected {pageTitle} page, but found {driver.Title} page.");
        //}
    }
}
