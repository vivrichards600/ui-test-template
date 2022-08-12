using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ui_test_template
{
    public class BasePage : Browser
    {
        protected void OnPage(string pageTitle)
        {
            if (driver.Title != pageTitle) throw PageNotFoundException(pageTitle);
        }

        private Exception PageNotFoundException(string pageTitle)
        {
            throw new Exception($"Expected {pageTitle} page, but found {driver.Title} page.");
        }

        protected void WaitForElementToBeVisible(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }

        protected void WaitForVisibilityOfAllElements(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
        }

        protected void WaitForElementToBeClickable(By by)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
        }
    }
}