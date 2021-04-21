using OpenQA.Selenium;
using System;

namespace GoogleSearchTest.Pages
{
    class GooglePage : BasePage
    {
        public GooglePage() : base() { }

        readonly By searchField = By.ClassName("gLFyf gsfi");
        readonly By searchButton = By.ClassName("gNO89b");

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

        public void SearcText(string text)
        {
            SendInfo(searchField, text);
            ClickButton(searchButton);
            CompareText(searchField, text);
        }
    }
}
