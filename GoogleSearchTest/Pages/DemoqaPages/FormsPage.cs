using GoogleSearchTest.Helpers;
using OpenQA.Selenium;
using System;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class FormsPage : BasePage
    {
        readonly By firstNameField = By.Id("firstName");
        readonly By lastNameField = By.Id("lastName");
        readonly By emailField = By.Id("userEmail");
        readonly By getnderRadioButton = By.XPath("//*[@id=\"genterWrapper\"]/div/div[1]");
        readonly By mobileNumberField = By.Id("userNumber");
        readonly By dateOfBirthField = By.Id("dateOfBirthInput");
        readonly By hobbiesRadioButton = By.XPath("//*[@id=\"hobbiesWrapper\"]/div/div[1]");
        readonly By addPictureButtun = By.Id("uploadPicture");
        readonly By subjectField = By.Id("subjectsInput");
        readonly By addressField = By.Id("currentAddress");
        readonly By stateDropdown = By.Id("state");
        readonly By stateDropdownValue = By.XPath("//div[@class=\" css-yt9ioa-option\"][1]");
        readonly By cityDropdown = By.Id("city");
        readonly By cityDropdownValue = By.XPath("//div[@class=\" css-yt9ioa-option\"][1]");
        readonly By submitButton = By.Id("submit");

        public void FillForm(string firstName, string lastName, string email, string mobileNumber, string dateOfBirth, string subject, string address)
        {
            SendInfo(firstNameField, firstName);
            SendInfo(lastNameField, lastName);
            SendInfo(emailField, email);
            ClickButton(getnderRadioButton);
            SendInfo(mobileNumberField, mobileNumber);
            PressKeysHelpers.SelectAllValues(wait, dateOfBirthField);
            SendInfo(dateOfBirthField, dateOfBirth);
            PressKeysHelpers.PressEnter(wait, dateOfBirthField);
            SendInfo(subjectField, subject);
            PressKeysHelpers.PressEnter(wait, subjectField);
            ClickButton(hobbiesRadioButton);
            SendInfo(addPictureButtun, AppDomain.CurrentDomain.BaseDirectory + "\\Image\\test.jpg");
            SendInfo(addressField, address);
            ClickButton(stateDropdown);
            ClickButton(stateDropdownValue);
            ClickButton(cityDropdown);
            ClickButton(cityDropdownValue);
            ClickButton(submitButton);
        }
    }
}
