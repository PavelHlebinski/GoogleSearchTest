using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class DataPage : BasePage
    {
        readonly By dateField = By.Id("datePickerMonthYearInput");
        readonly By dateTimeField = By.Id("dateAndTimePickerInput");

        public void CopmareDateFormat() => DataHelpers.IsDataFormatCorrect(WaitHelpers.WaitPresentElement(dateField, Wait).GetAttribute("value"));

        public void CopmareDateTimeFormat() => DataHelpers.IsDataTimeFormatCorrect(WaitHelpers.WaitPresentElement(dateTimeField, Wait).GetAttribute("value"));
    }
}
