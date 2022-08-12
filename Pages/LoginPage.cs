using OpenQA.Selenium;

namespace ui_test_template
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver _driver) => driver = _driver;
        readonly string Url = "https://sweetshop.netlify.app/login.html";
        public readonly string PageTitle = "Sweet Shop";

        public LoginPage LoadPage()
        {
            driver.Navigate().GoToUrl(Url);
            OnPage(PageTitle);
            return this;
        }

        public LoginPage InputEmailAddress(string text)
        {
            EmailAddressInput.SendKeys(text);
            return this;
        }

        public LoginPage InputPassword(string text)
        {
            PasswordInput.SendKeys(text);
            return this;
        }

        public LoginPage ClickLoginButton()
        {
            LoginButton.Click();
            return this;
        }

        private IWebElement EmailAddressInput => driver.FindElement(By.Id("exampleInputEmail"));
        private IWebElement PasswordInput => driver.FindElement(By.Id("exampleInputPassword"));
        private IWebElement LoginButton => driver.FindElement(By.ClassName("btn-primary"));
    }
}