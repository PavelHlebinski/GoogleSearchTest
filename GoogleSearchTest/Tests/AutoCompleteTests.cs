using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class AutoCompleteTests : BaseTest
    {
        [TestCase("Widgets", "Auto Complete", "Black", "Aqua", TestName = "Add few Values Test")]
        public void AddFewValuesTest(string mainButtonName, string expnadButtonName, string firstValue, string secondValue)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AutoCompletePage.AddFewValues(firstValue, secondValue);
        }

        [TestCase("Widgets", "Auto Complete", "a", "Magenta", TestName = "Select Value Test")]
        public void SelectValueTest(string mainButtonName, string expnadButtonName, string letter, string value)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AutoCompletePage.SelectValue(letter, value);
        }
    }
}
