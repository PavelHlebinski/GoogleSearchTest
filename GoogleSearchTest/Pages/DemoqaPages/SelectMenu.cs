using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class SelectMenu : BasePage
    {
        readonly By selectValueField = By.XPath("//*[@id=\"withOptGroup\"]/div/div[1]");
        readonly By selectValue = By.XPath("//div[@class=\" css-yt9ioa-option\"][2]");
        readonly By selectSecondValue = By.XPath("//div[@class=\" css-1n7v3ny-option\"]");
        readonly By selectOneField = By.XPath("//*[@id=\"selectOne\"]/div/div[1]");
        readonly By oldStyleMenu = By.Id("oldSelectMenu");
        readonly By multiselectDropDown = By.XPath("//*[@id=\"selectMenuContainer\"]/div[7]/div/div/div/div[1]");
        readonly By standartMultiselect = By.Id("cars");


        public void FillFields(string value, string carName)
        {
            ClickButton(selectValueField);
            ClickButton(selectValue);
            ClickButton(selectOneField);
            ClickButton(selectValue);
            BrowserHelpers.SelectDropDownValueByText(oldStyleMenu, value, wait);
            ClickButton(multiselectDropDown);
            ClickButton(selectValue);
            ClickButton(selectSecondValue);
            KeysHelpers.PressEnter(wait, standartMultiselect);
            BrowserHelpers.SelectDropDownValueByText(standartMultiselect, carName, wait);
        }
    }
}
