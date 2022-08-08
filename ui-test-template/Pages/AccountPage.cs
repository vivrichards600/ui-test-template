using System;
using OpenQA.Selenium;

namespace ui_test_template
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        public HomePage(IWebDriver _driver) => driver = _driver;

        readonly string Url = "https://sweetshop.netlify.app/";
        public readonly string ExpectedHomePageTitle = "Sweet Shop";

        public HomePage LoadPage()
        {
            driver.Navigate().GoToUrl(Url);
            //OnPage(ExpectedHomePageTitle);
            return this;
        }

        public HomePage GoToSweetsPage()
        {
            SweetsPageLink.Click();
            return this;
        }

        public IWebElement SweetsPageLink => driver.FindElement(By.XPath("//a[text()='Sweets']"));


       

    }
}
