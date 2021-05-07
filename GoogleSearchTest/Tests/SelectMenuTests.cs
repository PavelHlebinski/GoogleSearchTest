using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class SelectMenuTests : BaseTest
    {
        [TestCase("Widgets", "Select Menu", "Aqua", "Opel", TestName = "Fill All Fields Test")]
        public void FillAllFieldsTest(string mainButtonName, string expnadButtonName, string value, string carName)
        {
            MainPage.ScrollOpenPageForTests(mainButtonName, expnadButtonName);
            SelectMenu.FillFields(value, carName);
        }
    }
}
