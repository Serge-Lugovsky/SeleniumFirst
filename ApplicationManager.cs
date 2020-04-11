using System;
using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace SeleniumFirst
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