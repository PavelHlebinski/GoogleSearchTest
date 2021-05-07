using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class AllertsMessagesTests : BaseTest
    {
        [TestCase("Alerts, Frame & Windows", "Alerts", "You clicked a button", TestName = "Alert Test")]
        public void AlertTest(string mainButtonName, string expnadButtonName, string message)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AlertsPage.IsAlertOpened(message);
        }

        [TestCase("Alerts, Frame & Windows", "Alerts", "This alert appeared after 5 seconds", TestName = "Timer Alert Test")]
        public void TimerAlertTest(string mainButtonName, string expnadButtonName, string message)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AlertsPage.IsTimerAlertOpened(message);
        }

        [TestCase("Alerts, Frame & Windows", "Alerts", "Do you confirm action?", "You selected Ok", TestName = "Confirm Box Test")]
        public void ConfirmBoxTest(string mainButtonName, string expnadButtonName, string message, string confirmMessage)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AlertsPage.ConfirmBoxTest(message, confirmMessage);
        }

        [TestCase("Alerts, Frame & Windows", "Alerts", "pavel", TestName = "Prompt Box Test")]
        public void PromptBoxTest(string mainButtonName, string expnadButtonName, string text)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AlertsPage.PromptBoxButton(text);
        }
    }
}
