using OpenQA.Selenium;

namespace ui_test_template
{
    public class AccountPage
    {
        private readonly IWebDriver driver;
        public AccountPage(IWebDriver _driver) => driver = _driver;

        private IWebElement PageHeading => driver.FindElement(By.TagName("h1"));
        public string ActualPageHeadingText => PageHeading.Text;
        public string ExpectedPageHeadingText = "Your Account";

    }
}