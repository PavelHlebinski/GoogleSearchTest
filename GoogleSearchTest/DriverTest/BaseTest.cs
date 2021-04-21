using GoogleSearchTest.Driver;
using GoogleSearchTest.Pages;
using NUnit.Framework;
using System.Configuration;

namespace GoogleSearchTest.DriverTest
{
    class BaseTest
    {
        private readonly string url = ConfigurationManager.AppSettings["URL"];
        protected readonly GooglePage googlePage = new GooglePage();

        [SetUp]
        public void SetUp() => googlePage.OpenPage(url);

        [TearDown]
        public void TearDown() => DriverFactory.QuitDriver();
    }
}
