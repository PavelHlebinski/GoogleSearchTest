using GoogleSearchTest.Settings;
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

        public static IWebDriver InitializeDriver()
        {
            if (_driver == null)
            {
                _driver = SetupDriver();
            }
            return _driver;
        }

        private static IWebDriver SetupDriver()
        {
            if (AppSettings.ReadSettings().Browser == "Chrome")
            {
                return new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\Drivers");
            }
            return new EdgeDriver(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\Drivers");
        }

        public static WebDriverWait InitializeWait(IWebDriver driver, int timeOutInSeconds)
        {
            if (_wait == null || driver == null)
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

        public static void CloseDriver() => _driver.Close();
    }
}

