using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace GoogleSearchTest.Driver
{
    public class DriverFactory
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

        public static IWebDriver InitializeDriver(string browserName)
        {
            if (browserName == "Chrome")
            {
                return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\Drivers");
            }
            return new EdgeDriver(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\Drivers");
        }

        public static WebDriverWait InitializeWait(IWebDriver driver, int timeOutInSeconds)
        {
            if (_wait == null || _driver == null)
            {
                _wait = SetupDriverWait(driver, timeOutInSeconds);
            }
            return _wait;
        }

        private static WebDriverWait SetupDriverWait(IWebDriver driver, int timeOutInSeconds) => new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));

        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
            _wait = null;
        }
    }
}

