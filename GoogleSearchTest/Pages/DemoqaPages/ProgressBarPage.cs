using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class ProgressBarPage : BasePage
    {
        readonly By startButton = By.Id("startStopButton");
        readonly By resetButton = By.Id("resetButton");
        readonly By progressBar = By.XPath("//*[@id=\"progressBar\"]/div");

        public void IsProgressBarComplete()
        {
            ClickButton(startButton);
            WaitHelpers.WaitPresentElement(resetButton, Wait);
            CheckHelpers.CompareText(Driver.FindElement(progressBar).GetAttribute("class"), "success");
        }

        public void IsProgressBarReset()
        {
            ClickButton(startButton);
            WaitHelpers.WaitPresentElement(resetButton, Wait);
            CheckHelpers.CompareText(Driver.FindElement(progressBar).GetAttribute("class"), "success");
            ClickButton(resetButton);
            CheckHelpers.CompareText(Driver.FindElement(progressBar).GetAttribute("class"), "info");
        }
    }
}
