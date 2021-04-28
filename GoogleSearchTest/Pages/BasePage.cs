using GoogleSearchTest.Driver;
using GoogleSearchTest.Helpers;
using GoogleSearchTest.Settings;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;
        private readonly AppSettings config = AppSettings.ReadSettings();

        public BasePage()
        {
            driver = DriverFactory.InitializeDriver(config.Browser);
            driver.Manage().Window.Maximize();
            wait = DriverFactory.InitializeWait(driver, 10);
        }

        protected void SendInfo(By locator, string text) => WaitHelpers.WaitPresentElement(locator, wait).SendKeys(text);

        protected void ClickButton(By locator) => WaitHelpers.WaitClicableElement(locator, wait).Click();

        protected void CompareText(By locator, string compareText) => Assert.That(WaitHelpers.WaitPresentElement(locator, wait).Text, Does.Contain(compareText));
    }
}
