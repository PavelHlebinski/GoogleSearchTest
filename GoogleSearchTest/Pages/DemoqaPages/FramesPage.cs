using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class FramesPage : BasePage
    {
        readonly By bigFrame = By.Id("frame1");
        readonly By frameText = By.Id("sampleHeading");
        readonly By smallFrame = By.Id("frame2");

        public void BigFrameTest(string text)
        {
            BrowserHelpers.SwitchFrame(Driver, bigFrame);
            CheckHelpers.CompareText(Wait, frameText, text);
        }

        public void SmallFrameTest(string text)
        {
            BrowserHelpers.SwitchFrame(Driver, smallFrame);
            CheckHelpers.CompareText(Wait, frameText, text);
        }
    }
}
