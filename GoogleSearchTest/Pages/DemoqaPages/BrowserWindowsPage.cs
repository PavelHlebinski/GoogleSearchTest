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
            CompareText(title);
            BrowserHelpers.CloseTab(driver, 1);
        }

        public void NewWindowTitleTest(string title)
        {
            ClickButton(newWindowButton);
            BrowserHelpers.SwitchWindow(driver);
            CompareText(title);
            BrowserHelpers.CloseWindow(driver);
        }

        public void NewWindowMessageTitleTest()
        {
            ClickButton(newWindowMessageButton);
            BrowserHelpers.CloseWindow(driver);
        }
    }
}
