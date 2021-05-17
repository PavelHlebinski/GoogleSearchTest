using GoogleSearchTest.Driver;
using GoogleSearchTest.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Pages
{
    public class BasePage
    {
        protected static WebDriverWait Wait;
        protected static IWebDriver Driver;

        public BasePage()
        {
            Driver = DriverFactory.InitializeDriver();
            Driver.Manage().Window.Maximize();
            Wait = DriverFactory.InitializeWait(DriverFactory.InitializeDriver(), 10);
        }

        protected void SendInfo(By locator, string text) => WaitHelpers.WaitPresentElement(locator, Wait).SendKeys(text);

        protected void ClickButton(By locator) => WaitHelpers.WaitClicableElement(locator, Wait).Click();
    }
}
