using System;
using System.Collections.Generic;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using SeleniumFirst.managers;
using SeleniumFirst.utils;

namespace SeleniumFirst.tests
{
    [TestFixture]
    [AllureNUnit]
    class TestBase
    {
        private ApplicationManager App { get; set; }

        [OneTimeSetUp]
        public void InitialSetup()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }
    
        [SetUp]
        public void Initialize()
        {
            App = SingletonAppManager.GetInstance().App;
            App.Driver.Navigate().GoToUrl("https://app.kidslox.com");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.FailCount > 0) ScreenshotListener.SaveScreenshot(App);
            App.Driver.Close();
            App.Driver.Quit();
            SingletonAppManager.ResetSingleton();
        }
        
        

        [Test(Description = "First")]
        [AllureTag("Debug")]
        public void ExecuteTests()
        {
            App.UserHelper.Login("qatestvob@appcreative.net", "qwerty");
            Assert.AreEqual("Controlled devices", App.AttributeHelper.GetDevicesPageHeader());
        }
    
        [Test(Description = "Second")]
        [AllureTag("Smoke")]
        public void ExecuteTests2()
        {
            App.UserHelper.Login("qatestvob@appcreative.net", "qwerty");
            IList<string> tabsNames = new List<string> {"Test1", "Test2", "Test3"};
            Assert.AreEqual(tabsNames, App.AttributeHelper.GetTopMenuTabsNames());
        }
    }
}