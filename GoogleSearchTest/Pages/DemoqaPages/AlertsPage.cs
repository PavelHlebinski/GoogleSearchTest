using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class AlertsPage : BasePage
    {
        readonly By alertButton = By.Id("alertButton");
        readonly By timerAlertButton = By.Id("timerAlertButton");
        readonly By confirmBoxtButton = By.Id("confirmButton");
        readonly By confirmResult = By.Id("confirmResult");
        readonly By promptBoxButton = By.Id("promtButton");
        readonly By promptResult = By.Id("promptResult");

        public void AlertTest(string message)
        {
            ClickButton(alertButton);
            CompareText(AlertsHelpers.GetAlertText(driver), message);
            AlertsHelpers.AcceptAlert(driver);
        }

        public void AlertTimerTest(string message)
        {
            ClickButton(timerAlertButton);
            wait.Until(drver => AlertsHelpers.IsAlertShown(driver));
            CompareText(AlertsHelpers.GetAlertText(driver), message);
            AlertsHelpers.AcceptAlert(driver);
        }

        public void ConfirmBoxTest(string message, string confirmMessage)
        {
            ClickButton(confirmBoxtButton);
            CompareText(AlertsHelpers.GetAlertText(driver), message);
            AlertsHelpers.AcceptAlert(driver);
            CompareText(confirmResult, confirmMessage);
        }

        public void PromptBoxButton(string text)
        {
            ClickButton(promptBoxButton);
            AlertsHelpers.SendAlertText(driver, text);
            AlertsHelpers.AcceptAlert(driver);
            CompareText(promptResult, text);
        }
    }
}
