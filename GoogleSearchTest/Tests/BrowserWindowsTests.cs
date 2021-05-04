using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class BrowserWindowsTests : BaseTest
    {
        [TestCase("", TestName = "New Tab Tittle Test")]
        public void NewTabTittleTest(string title)
        {
            MainPage.OpenBrowserWindowsPage();
            BrowserWindowsPage.NewTabTitleTest(title);
        }

        [TestCase("", TestName = "New Window Tittle Test")]
        public void NewWindowTittleTest(string title)
        {
            MainPage.OpenBrowserWindowsPage();
            BrowserWindowsPage.NewWindowTitleTest(title);
        }

        [TestCase(TestName = "New Window Mesage Tittle Test")]
        public void NewWindowMessageTittleTest()
        {
            MainPage.OpenBrowserWindowsPage();
            BrowserWindowsPage.NewWindowMessageTitleTest();
        }
    }
}
