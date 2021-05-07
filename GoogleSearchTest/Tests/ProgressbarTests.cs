using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class ProgressbarTests : BaseTest
    {
        [TestCase("Widgets", "Progress Bar", TestName = "Progress Bar Complete Test")]
        public void ProgressBarCompleteTest(string mainButtonName, string expnadButtonName)
        {
            MainPage.ScrollOpenPageForTests(mainButtonName, expnadButtonName);
            ProgressBarPage.IsProgressBarComplete();
        }

        [TestCase("Widgets", "Progress Bar", TestName = "Progress Bar Reset Test")]
        public void ProgressBarResetTest(string mainButtonName, string expnadButtonName)
        {
            MainPage.ScrollOpenPageForTests(mainButtonName, expnadButtonName);
            ProgressBarPage.IsProgressBarReset();
        }
    }
}
