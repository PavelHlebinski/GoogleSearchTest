using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class DataPage : BasePage
    {
        readonly By dateField = By.Id("datePickerMonthYearInput");
        readonly By dateTimeField = By.Id("dateAndTimePickerInput");

        public void CopmareDateFormat() => DataHelpers.IsDataFormatCorrect(WaitHelpers.WaitPresentElement(dateField, wait).GetAttribute("value"));

        public void CopmareDateTimeFormat() => DataHelpers.IsDataTimeFormatCorrect(WaitHelpers.WaitPresentElement(dateTimeField, wait).GetAttribute("value"));
    }
}
