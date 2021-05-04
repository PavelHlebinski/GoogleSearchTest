using OpenQA.Selenium;

namespace GoogleSearchTest.Helpers
{
    public class AlertsHelpers
    {
        public static string GetAlertText(IWebDriver driver) => driver.SwitchTo().Alert().Text;

        public static void AcceptAlert(IWebDriver driver) => driver.SwitchTo().Alert().Accept();

        public static bool IsAlertShown(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
            return true;
        }

        public static void SendAlertText(IWebDriver driver, string text) => driver.SwitchTo().Alert().SendKeys(text);
    }
}
