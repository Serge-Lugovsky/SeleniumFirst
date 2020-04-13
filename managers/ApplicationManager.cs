using OpenQA.Selenium;
using SeleniumFirst.helpers;
using SeleniumFirst.utils;

namespace SeleniumFirst.managers
{
    public class ApplicationManager
    {
        public UserHelper UserHelper{get;}
        public AttributeHelper AttributeHelper{get;}
        public IWebDriver Driver { get; private set; }

        internal ApplicationManager()
        {
            Driver = WebDriver.GetInstanceDriver();
            UserHelper = new UserHelper(this);
            AttributeHelper = new AttributeHelper(this);
        }

    }
}