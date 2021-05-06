using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class FormTests : BaseTest
    {
        [TestCase("Forms", "Practice Form", "first", "last", "test@test.com", "1231231234", "30 May,1999", "Arts", "1561 Woodland Drive", TestName = "Form Test")]
        public void FormTest(string mainButtonName, string expnadButtonName, string firstName, string lastName, string email, string mobileNumber, string dateOfBirth, string subject, string address)
        {
            MainPage.OpenPage(mainButtonName, expnadButtonName);
            FormsPage.FillForm(firstName, lastName, email, mobileNumber, dateOfBirth, subject, address);
            SubmitFormPage.CompareValues(firstName, lastName, email, mobileNumber, dateOfBirth, subject, address);
        }
    }
}
