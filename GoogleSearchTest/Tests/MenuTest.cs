using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class MenuTest : BaseTest
    {
        [TestCase("Widgets", "Menu", TestName = "Sub Item Clicable test")]
        public void SubItemClicabletest(string mainButtonName, string expnadButtonName)
        {
            MainPage.ScrollOpenPageForTests(mainButtonName, expnadButtonName);
            MenuPage.ClickSubItem();
        }
    }
}
