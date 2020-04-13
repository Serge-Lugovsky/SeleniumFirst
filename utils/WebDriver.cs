using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst.utils
{
    public static class WebDriver
    {
        private static IWebDriver _driver;
        public static IWebDriver GetInstanceDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--start-fullscreen");
            _driver = new ChromeDriver(chromeOptions);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return _driver;
        }
        
    }
}