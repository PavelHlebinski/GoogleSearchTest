using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class AutoCompleteTests : BaseTest
    {
        [TestCase("Black", "Aqua", TestName = "Add few Values Test")]
        public void AddFewValuesTest(string firstValue, string secondValue)
        {
            MainPage.OpenAutoCompletePage();
            AutoCompletePage.AddFewValues(firstValue, secondValue);
        }

        [TestCase("a", "Magenta", TestName = "Select Value Test")]
        public void SelectValueTest(string letter, string value)
        {
            MainPage.OpenAutoCompletePage();
            AutoCompletePage.SelectValue(letter, value);
        }
    }
}
