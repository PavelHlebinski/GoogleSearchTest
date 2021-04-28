using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.PageTest
{
    public class GooglePageTest : BaseTest
    {
        [TestCase("Google", TestName = "Google Search Test")]
        public void SearchTest(string text)
        {
            googlePage.SearcText(text);
        }
    }
}
