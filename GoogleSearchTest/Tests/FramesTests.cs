using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class FramesTests : BaseTest
    {
        [TestCase("This is a sample page", TestName = "Big Frame Test")]
        public void BigFrameTest(string text)
        {
            MainPage.OpenFramesPage();
            FramesPage.BigFrameTest(text);
        }

        [TestCase("This is a sample page", TestName = "Small Frame Test")]
        public void SmallFrameTest(string text)
        {
            MainPage.OpenFramesPage();
            FramesPage.SmallFrameTest(text);
        }
    }
}
