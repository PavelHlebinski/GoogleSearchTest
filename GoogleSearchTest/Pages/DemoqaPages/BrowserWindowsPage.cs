using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class BrowserWindowsPage : BasePage
    {
        readonly By newTabButton = By.Id("tabButton");
        readonly By newWindowButton = By.Id("windowButton");
        readonly By newWindowMessageButton = By.Id("messageWindowButton");

        public void NewTabTitleTest(string title)
        {
            ClickButton(newTabButton);
            BrowserHelpers.SwitchTab(Driver, 1);
            CheckHelpers.CompareText(Driver, title);
            BrowserHelpers.CloseTab(Driver, 1);
            BrowserHelpers.SwitchTab(Driver, 0);
        }

        public void NewWindowTitleTest(string title)
        {
            ClickButton(newWindowButton);
            BrowserHelpers.SwitchWindow(Driver);
            CheckHelpers.CompareText(Driver, title);
            BrowserHelpers.CloseWindow(Driver);
        }

        public void NewWindowMessageTitleTest()
        {
            ClickButton(newWindowMessageButton);
            BrowserHelpers.CloseWindow(Driver);
            BrowserHelpers.SwitchTab(Driver, 0);
        }
    }
}
