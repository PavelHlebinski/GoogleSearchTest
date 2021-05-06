using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class AllertsMessagesTests : BaseTest
    {
        [TestCase("You clicked a button", TestName = "Alert Test")]
        public void AlertTest(string message)
        {
            MainPage.OpenAlertsPage();
            AlertsPage.IsAlertOpened(message);
        }

        [TestCase("This alert appeared after 5 seconds", TestName = "Timer Alert Test")]
        public void TimerAlertTest(string message)
        {
            MainPage.OpenAlertsPage();
            AlertsPage.IsTimerAlertOpened(message);
        }

        [TestCase("Do you confirm action?", "You selected Ok", TestName = "Confirm Box Test")]
        public void ConfirmBoxTest(string message, string confirmMessage)
        {
            MainPage.OpenAlertsPage();
            AlertsPage.ConfirmBoxTest(message, confirmMessage);
        }

        [TestCase("pavel", TestName = "Prompt Box Test")]
        public void PromptBoxTest(string text)
        {
            MainPage.OpenAlertsPage();
            AlertsPage.PromptBoxButton(text);
        }
    }
}
