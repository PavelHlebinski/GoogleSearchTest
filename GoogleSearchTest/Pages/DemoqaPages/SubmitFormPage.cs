using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class SubmitFormPage : BasePage
    {
        readonly By closeButton = By.Id("closeLargeModal");

        private By GetElement(int i) => By.XPath($"/html/body/div[3]/div/div/div[2]/div/table/tbody/tr[{i}]/td[2]");

        public void CompareValues(string firstName, string lastName, string email, string mobileNumber, string dateOfBirth, string subject, string address)
        {
            string[] temp = new string[] { firstName + " " + lastName, email, "Male", mobileNumber, dateOfBirth, subject, "Sport", "test.jpg", address, "NCR Gurgaon" };
            for (int i = 1; i < 10; i++)
            {
                CheckHelpers.CompareText(Wait, GetElement(i), temp[i - 1]);
            }
            ClickButton(closeButton);
        }
    }
}
