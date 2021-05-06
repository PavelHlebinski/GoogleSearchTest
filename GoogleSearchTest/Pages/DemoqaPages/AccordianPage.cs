using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class AccordianPage : BasePage
    {
        readonly By section1Content = By.Id("section1Content");
        readonly By section2Button = By.Id("section2Heading");
        readonly By section2Content = By.Id("section2Content");
        readonly By section3Button = By.Id("section3Heading");
        readonly By section3Content = By.Id("section3Content");

        public void IsAccordianTextPresent(string firstText, string secondText, string thirdtext)
        {
            CheckHelpers.CompareText(wait, section1Content, firstText);
            ClickButton(section2Button);
            WaitHelpers.WaitVisibleElement(section2Content, wait);
            CheckHelpers.CompareText(wait, section2Content, secondText);
            ClickButton(section3Button);
            WaitHelpers.WaitVisibleElement(section3Content, wait);
            CheckHelpers.CompareText(wait, section3Content, thirdtext);
        }
    }
}
