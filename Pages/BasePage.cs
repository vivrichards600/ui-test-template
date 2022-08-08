using System;
using OpenQA.Selenium;

namespace ui_test_template
{
    public class BasePage
    {
        public void OnPage(IWebDriver driver, string pageTitle)
        {
            if (driver.Title != pageTitle) throw PageNotFoundException(driver, pageTitle);
        }

        private Exception PageNotFoundException(IWebDriver driver, string pageTitle)
        {
            throw new Exception($"Expected {pageTitle} page, but found {driver.Title} page.");
        }
    }
}