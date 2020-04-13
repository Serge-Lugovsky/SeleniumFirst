using System;
using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using SeleniumFirst.managers;

namespace SeleniumFirst.pages
{
    public class Page
    {
        protected IWebDriver Driver { get; }
        protected IJavaScriptExecutor Jse { get; }
        private PageManager _pageManager;

        protected Page(PageManager pageManager)
        {
            this._pageManager = pageManager;
            Jse = (IJavaScriptExecutor) Driver;
            Driver = pageManager.Driver;

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