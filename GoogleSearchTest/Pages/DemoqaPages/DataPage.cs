using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class DataPage : BasePage
    {
        readonly By dateField = By.Id("datePickerMonthYearInput");
        readonly By dateTimeField = By.Id("dateAndTimePickerInput");

        public void CopmareDateFormat()
        {
            string data = WaitHelpers.WaitPresentElement(dateField, wait).GetAttribute("value");
            string checkResult = DataHelpers.IsDataFormatCorrect(data).ToString();
            CheckHelpers.CompareText(checkResult, "True");
        }
        public void CopmareDateTimeFormat()
        {
            string data = WaitHelpers.WaitPresentElement(dateTimeField, wait).GetAttribute("value");
            string checkResult = DataHelpers.IsDataTimeFormatCorrect(data).ToString();
            CheckHelpers.CompareText(checkResult, "True");
        }
    }
}
