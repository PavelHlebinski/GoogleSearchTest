using GoogleSearchTest.Driver;
using GoogleSearchTest.Helpers;
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
    }
}
