using OpenQA.Selenium;
using System;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class MainPage : BasePage
    {
        private By SelectMainButton(string buttonName) => By.XPath($"//div[@class=\"card mt-4 top-card\"]//*[text()='{buttonName}']");

        private By SelectExpandedButton(string buttonName) => By.XPath($"//*[@class=\"btn btn-light \"]//*[text()='{buttonName}']");

        public void OpenPage(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch
            {
                Console.WriteLine("URL not found");
            }
        }

        public void OpenFormsPage()
        {
            ClickButton(SelectMainButton("Forms"));
            ClickButton(SelectExpandedButton("Practice Form"));
        }

        public void OpenBrowserWindowsPage()
        {
            ClickButton(SelectMainButton("Alerts, Frame & Windows"));
            ClickButton(SelectExpandedButton("Browser Windows"));
        }

        public void OpenAlertsPage()
        {
            ClickButton(SelectMainButton("Alerts, Frame & Windows"));
            ClickButton(SelectExpandedButton("Alerts"));
        }

        public void OpenFramesPage()
        {
            ClickButton(SelectMainButton("Alerts, Frame & Windows"));
            ClickButton(SelectExpandedButton("Frames"));
        }

        public void OpenDialogsPage()
        {
            ClickButton(SelectMainButton("Alerts, Frame & Windows"));
            ClickButton(SelectExpandedButton("Modal Dialogs"));
        }

        public void OpenAccordianPage()
        {
            ClickButton(SelectMainButton("Widgets"));
            ClickButton(SelectExpandedButton("Accordian"));
        }

        public void OpenAutoCompletePage()
        {
            ClickButton(SelectMainButton("Widgets"));
            ClickButton(SelectExpandedButton("Auto Complete"));
        }
    }
}
