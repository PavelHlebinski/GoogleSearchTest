using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
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

        public static void SelectDropDownValueByText(By locator, string text, WebDriverWait wait) => new SelectElement(WaitHelpers.WaitPresentElement(locator, wait)).SelectByText(text);

        public static void HoverMouse(By locator, IWebDriver driver)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(locator)).Perform();
        }

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
