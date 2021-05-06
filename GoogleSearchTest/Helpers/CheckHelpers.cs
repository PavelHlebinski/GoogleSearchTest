using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Helpers
{
    public class CheckHelpers
    {
        public static void CompareText(WebDriverWait wait, By locator, string compareText) => Assert.That(WaitHelpers.WaitPresentElement(locator, wait).Text, Does.Contain(compareText));

        public static void CompareText(string message, string compareMessage) => Assert.That(message, Does.Contain(compareMessage));

        public static void CompareText(IWebDriver driver, string message) => Assert.That(driver.Title, Does.Contain(message));
    }
}
