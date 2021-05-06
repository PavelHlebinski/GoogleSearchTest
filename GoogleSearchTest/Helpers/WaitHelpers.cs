using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Helpers
{
    public class WaitHelpers
    {
        public static IWebElement WaitPresentElement(By locator, WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));

        public static IWebElement WaitClicableElement(By locator, WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));

        public static IWebElement WaitVisibleElement(By locator, WebDriverWait wait) => wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
    }
}
