using GoogleSearchTest.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;

namespace GoogleSearchTest.Pages
{
    class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage()
        {
            driver = DriverFactory.InitDriver(ConfigurationManager.AppSettings["Browser"]);
            driver.Manage().Window.Maximize();
            wait = DriverFactory.InitWait(driver, 10);
        }

        private IWebElement WaitPresentElement(By locator) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));

        private IWebElement WaitClicableElement(By locator) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));

        protected void SendInfo(By locator, string text) => WaitPresentElement(locator).SendKeys(text);

        protected void ClickButton(By locator) => WaitClicableElement(locator).Click();

        protected void CompareText(By locator, string compareText) => Assert.That(WaitPresentElement(locator).Text, Does.Contain(compareText));

    }
}
