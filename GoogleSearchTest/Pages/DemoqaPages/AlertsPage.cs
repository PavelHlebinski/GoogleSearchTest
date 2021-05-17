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

        public void IsAlertOpened(string message)
        {
            ClickButton(alertButton);
            CheckHelpers.CompareText(AlertsHelpers.GetAlertText(Driver), message);
            AlertsHelpers.AcceptAlert(Driver);
        }

        public void IsTimerAlertOpened(string message)
        {
            ClickButton(timerAlertButton);
            Wait.Until(drver => AlertsHelpers.IsAlertShown(Driver));
            CheckHelpers.CompareText(AlertsHelpers.GetAlertText(Driver), message);
            AlertsHelpers.AcceptAlert(Driver);
        }

        public void ConfirmBoxTest(string message, string confirmMessage)
        {
            ClickButton(confirmBoxtButton);
            CheckHelpers.CompareText(AlertsHelpers.GetAlertText(Driver), message);
            AlertsHelpers.AcceptAlert(Driver);
            CheckHelpers.CompareText(Wait, confirmResult, confirmMessage);
        }

        public void PromptBoxButton(string text)
        {
            ClickButton(promptBoxButton);
            AlertsHelpers.SendAlertText(Driver, text);
            AlertsHelpers.AcceptAlert(Driver);
            CheckHelpers.CompareText(Wait, promptResult, text);
        }
    }
}
