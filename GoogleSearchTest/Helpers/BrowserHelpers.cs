using OpenQA.Selenium;
using System.Linq;

namespace GoogleSearchTest.Helpers
{
    public class BrowserHelpers
    {
        public static void SwitchTab(IWebDriver driver, int tabNumber) => driver.SwitchTo().Window(driver.WindowHandles[tabNumber]);

        public static void CloseTab(IWebDriver driver, int tabNumber) => driver.SwitchTo().Window(driver.WindowHandles[tabNumber]).Close();

        public static void SwitchWindow(IWebDriver driver) => driver.SwitchTo().Window(driver.WindowHandles.ToList().Last());

        public static void CloseWindow(IWebDriver driver) => driver.SwitchTo().Window(driver.WindowHandles.ToList().Last()).Close();

        public static void SwitchFrame(IWebDriver driver, By locator) => driver.SwitchTo().Frame(driver.FindElement(locator));

        public static string GetDialogText(IWebDriver driver) => driver.SwitchTo().ActiveElement().Text;

        public static bool IsDialogShown(IWebDriver driver, By locator)
        {
            try
            {
                driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                return true;
            }
            return false;
        }
    }
}
