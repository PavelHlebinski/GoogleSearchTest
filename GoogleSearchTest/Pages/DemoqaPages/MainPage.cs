﻿using OpenQA.Selenium;
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

        public void OpenPage(string mainButtonName, string expandButtomName)
        {
            ClickButton(SelectMainButton(mainButtonName));
            ClickButton(SelectExpandedButton(expandButtomName));
        }
    }
}
