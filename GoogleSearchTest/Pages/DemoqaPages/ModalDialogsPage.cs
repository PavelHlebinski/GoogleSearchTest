using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class ModalDialogsPage : BasePage
    {
        readonly By smallModalButton = By.Id("showSmallModal");
        readonly By modalWindow = By.ClassName("modal-content");
        readonly By largeModalButton = By.Id("showLargeModal");
        readonly By closeSmallDialogButton = By.Id("closeSmallModal");
        readonly By closeLargeDialogButton = By.Id("closeSmallModal");


        public void SmallModalWindowTest(string text)
        {
            ClickButton(smallModalButton);
            WaitHelpers.WaitPresentElement(modalWindow, wait);
            CompareText(BrowserHelpers.GetDialogText(driver), text);
            ClickButton(closeSmallDialogButton);
            BrowserHelpers.IsDialogShown(driver, modalWindow);
        }

        public void LargeModalWindowTest(string text)
        {
            ClickButton(largeModalButton);
            WaitHelpers.WaitPresentElement(modalWindow, wait);
            CompareText(BrowserHelpers.GetDialogText(driver), text);
            ClickButton(closeLargeDialogButton);
            BrowserHelpers.IsDialogShown(driver, modalWindow);
        }
    }
}
