using GoogleSearchTest.Driver;
using GoogleSearchTest.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Pages
{
    public class BasePage
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;

        public BasePage()
        {
            driver = DriverFactory.InitializeDriver();
            driver.Manage().Window.Maximize();
            wait = DriverFactory.InitializeWait(DriverFactory.InitializeDriver(), 10);
        }

        protected void SendInfo(By locator, string text) => WaitHelpers.WaitPresentElement(locator, wait).SendKeys(text);

        protected void ClickButton(By locator) => WaitHelpers.WaitClicableElement(locator, wait).Click();

        protected void CompareText(By locator, string compareText) => Assert.That(WaitHelpers.WaitPresentElement(locator, wait).Text, Does.Contain(compareText));

        protected void CompareText(string message, string compareMessage) => Assert.That(message, Does.Contain(compareMessage));

        protected void CompareText(string message) => Assert.That(driver.Title, Does.Contain(message));
    }
}
