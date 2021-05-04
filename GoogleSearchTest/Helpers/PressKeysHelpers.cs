using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Helpers
{
    public class PressKeysHelpers
    {
        public static void PressEnter(WebDriverWait wait, By locator) => WaitHelpers.WaitClicableElement(locator, wait).SendKeys(Keys.Enter);

        public static void SelectAllValues(WebDriverWait wait, By locator) => WaitHelpers.WaitClicableElement(locator, wait).SendKeys(Keys.Control + "a");
    }
}
