using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class BrowserWindowsTests : BaseTest
    {
        [TestCase("Alerts, Frame & Windows", "Browser Windows", "", TestName = "New Tab Tittle Test")]
        public void NewTabTittleTest(string mainButtonName, string expnadButtonName, string title)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            BrowserWindowsPage.NewTabTitleTest(title);
        }

        [TestCase("Alerts, Frame & Windows", "Browser Windows", "", TestName = "New Window Tittle Test")]
        public void NewWindowTittleTest(string mainButtonName, string expnadButtonName, string title)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            BrowserWindowsPage.NewWindowTitleTest(title);
        }

        [TestCase("Alerts, Frame & Windows", "Browser Windows", TestName = "New Window Message Tittle Test")]
        public void NewWindowMessageTittleTest(string mainButtonName, string expnadButtonName)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            BrowserWindowsPage.NewWindowMessageTitleTest();
        }
    }
}
