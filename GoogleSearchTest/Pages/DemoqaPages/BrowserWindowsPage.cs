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
            BrowserHelpers.SwitchTab(driver, 1);
            CheckHelpers.CompareText(driver, title);
            BrowserHelpers.CloseTab(driver, 1);
            BrowserHelpers.SwitchTab(driver, 0);
        }

        public void NewWindowTitleTest(string title)
        {
            ClickButton(newWindowButton);
            BrowserHelpers.SwitchWindow(driver);
            CheckHelpers.CompareText(driver, title);
            BrowserHelpers.CloseWindow(driver);
        }

        public void NewWindowMessageTitleTest()
        {
            ClickButton(newWindowMessageButton);
            BrowserHelpers.CloseWindow(driver);
            BrowserHelpers.SwitchTab(driver, 0);
        }
    }
}
