using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace GoogleSearchTest.Driver
{
    class DriverFactory
    {
        private static IWebDriver _driver;
        private static WebDriverWait _wait;

        public static IWebDriver Driver
        {
            get
            {
                if (_driver == null)
                    throw new NullReferenceException("WebDriver not found.");
                return _driver;
            }
            private set
            {
                _driver = value;
            }
        }

        public static IWebDriver InitDriver(string browserName)
        {
            if (browserName == "Chrome")
            {
                return new ChromeDriver(Environment.CurrentDirectory + "\\..\\..\\..\\Drivers");
            }
            return new EdgeDriver(Environment.CurrentDirectory + "\\..\\..\\..\\Drivers");
        }

        public static WebDriverWait InitWait(IWebDriver driver, int sec)
        {
            if (_wait == null || _driver == null)
            {
                _wait = SetupDriverWait(driver, sec);
            }
            return _wait;
        }

        public static WebDriverWait SetupDriverWait(IWebDriver driver, int sec) => new WebDriverWait(driver, TimeSpan.FromSeconds(sec));

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
            _wait = null;
        }
    }
}

