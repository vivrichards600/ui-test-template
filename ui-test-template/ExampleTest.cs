using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ui_test_template
{
    [TestClass]
    public class ExampleTest : BasePage
    {
        [TestMethod]
        public void HomePageTest()
        {
            HomePage home = new HomePage(driver);
            home.LoadPage();
                //.GoToSweetsPage();

            OnPage(home.PageTitle);
        }

    }
}
