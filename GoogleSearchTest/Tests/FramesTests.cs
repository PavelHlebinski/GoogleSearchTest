using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class FramesTests : BaseTest
    {
        [TestCase("Alerts, Frame & Windows", "Frames", "This is a sample page", TestName = "Big Frame Test")]
        public void BigFrameTest(string mainButtonName, string expnadButtonName, string text)
        {
            MainPage.OpenPage(mainButtonName, expnadButtonName);
            FramesPage.BigFrameTest(text);
        }

        [TestCase("Alerts, Frame & Windows", "Frames", "This is a sample page", TestName = "Small Frame Test")]
        public void SmallFrameTest(string mainButtonName, string expnadButtonName, string text)
        {
            MainPage.OpenPage(mainButtonName, expnadButtonName);
            FramesPage.SmallFrameTest(text);
        }
    }
}
