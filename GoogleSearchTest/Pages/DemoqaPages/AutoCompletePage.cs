using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class AutoCompletePage : BasePage
    {
        readonly By multipleField = By.Id("autoCompleteMultipleInput");
        readonly By multiplefieldFirstValue = By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]/div/div[1]/div[1]");
        readonly By multiplefieldSecondValue = By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]/div/div[1]/div[2]");
        readonly By multipleFielDeleteButton = By.XPath("//*[@id=\"autoCompleteMultipleContainer\"]/div/div[2]/div");
        readonly By singleLineField = By.Id("autoCompleteSingleInput");
        readonly By singleLineFieldValue = By.XPath("//*[@id=\"autoCompleteSingleContainer\"]/div/div[1]/div[1]");

        public void AddFewValues(string firstValue, string secondValue)
        {
            SendInfo(multipleField, firstValue);
            PressKeysHelpers.PressEnter(wait, multipleField);
            SendInfo(multipleField, secondValue);
            PressKeysHelpers.PressEnter(wait, multipleField);
            WaitHelpers.WaitPresentElement(multiplefieldFirstValue, wait);
            WaitHelpers.WaitPresentElement(multiplefieldSecondValue, wait);
            ClickButton(multipleFielDeleteButton);
            CheckHelpers.CompareText(wait, multipleField, "");
        }

        public void SelectValue(string letter, string value)
        {
            SendInfo(singleLineField, letter);
            PressKeysHelpers.PressDown(wait, singleLineField);
            PressKeysHelpers.PressEnter(wait, singleLineField);
            CheckHelpers.CompareText(wait, singleLineFieldValue, value);
        }
    }
}
