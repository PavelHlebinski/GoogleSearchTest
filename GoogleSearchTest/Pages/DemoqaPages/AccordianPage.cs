using GoogleSearchTest.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class AccordianPage : BasePage
    {
        readonly By section1Content = By.Id("section1Content");
        readonly By section2Button = By.Id("section2Heading");
        readonly By section2Content = By.Id("section2Content");
        readonly By section3Button = By.Id("section3Heading");
        readonly By section3Content = By.Id("section3Content");

        public void ShowAccordianText(string firstText, string secondText, string thirdtext)
        {
            CheckHelpers.CompareText(Wait, section1Content, firstText);
            OpenContent(section2Button, section2Content, Wait, secondText);
            OpenContent(section3Button, section3Content, Wait, thirdtext);
        }

        private void OpenContent(By button, By content, WebDriverWait wait, string text)
        {
            ClickButton(button);           
            CheckHelpers.CompareText(wait, content, text);
        }
    }
}
