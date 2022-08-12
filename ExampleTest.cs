using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ui_test_template
{
    [TestClass]
    public class ExampleTest : Browser
    {
        [TestMethod]
        public void HomePageTest()
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.LoadPage()
                .InputEmailAddress("test@user.com")
                .InputPassword("qwerty")
                .ClickLoginButton();

            AccountPage accountPage = new AccountPage(driver);
            Assert.AreEqual(accountPage.ActualPageHeadingText, accountPage.ExpectedPageHeadingText);
        }
    }
}
