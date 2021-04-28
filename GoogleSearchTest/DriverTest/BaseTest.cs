using GoogleSearchTest.Driver;
using GoogleSearchTest.Pages;
using GoogleSearchTest.Settings;
using NUnit.Framework;

namespace GoogleSearchTest.DriverTest
{
    public class BaseTest
    {
        private readonly string url = AppSettings.ReadSettings().URL;
        protected readonly GooglePage googlePage = new GooglePage();

        [SetUp]
        public void SetUp() => googlePage.OpenPage(url);

        [TearDown]
        public void TearDown() => DriverFactory.QuitDriver();
    }
}
