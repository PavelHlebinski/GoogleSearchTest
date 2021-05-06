using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class DataTests : BaseTest
    {
        [TestCase("Widgets", "Date Picker", TestName = "Simple Data Format Test")]
        public void SimpleDataFormatTest(string mainButtonName, string expandButtonName)
        {
            MainPage.OpenPage(mainButtonName, expandButtonName);
            DataPage.CopmareDateFormat();
        }

        [TestCase("Widgets", "Date Picker", TestName = "Data Time Format Test")]
        public void DataTimeFormatTest(string mainButtonName, string expandButtonName)
        {
            MainPage.OpenPage(mainButtonName, expandButtonName);
            DataPage.CopmareDateTimeFormat();
        }
    }
}
