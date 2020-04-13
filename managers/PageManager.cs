using System;
using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SeleniumFirst.pages;

namespace SeleniumFirst.managers
{
    public class PageManager
    {
        public IWebDriver Driver { get; private set; }

        protected LoginPage LoginPage { get; private set; }
        protected DevicesPage DevicesPage { get; private set; }

        protected PageManager(IWebDriver driver)
        {
            Driver = driver;
            LoginPage = new LoginPage(this);
            DevicesPage = new DevicesPage(this);
        }

        protected void Step(string stepName, Action method)
        {
            AllureLifecycle.Instance.WrapInStep(
                method,
                stepName
            );
        }

        protected void Step(string stepName)
        {
            Step(stepName,() => {});
        }

    }

}