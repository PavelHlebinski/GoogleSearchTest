﻿using GoogleSearchTest.Helpers;
using OpenQA.Selenium;

namespace GoogleSearchTest.Pages.DemoqaPages
{
    public class MenuPage : BasePage
    {
        readonly By mainItem2 = By.XPath("//*[@id=\"nav\"]/li[2]/a");
        readonly By subList = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/a");
        readonly By subItem = By.XPath("//*[@id=\"nav\"]/li[2]/ul/li[3]/ul/li[2]/a");

        public void IsSubItemClicable()
        {
            BrowserHelpers.HoverMouse(mainItem2, driver);
            BrowserHelpers.HoverMouse(subList, driver);
            WaitHelpers.WaitClicableElement(subItem, wait);
        }
    }
}
