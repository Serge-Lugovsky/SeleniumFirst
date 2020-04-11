
using System;
using Allure.Commons;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;

namespace SeleniumFirst
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
            var browser = TestContext.Parameters.Get("Browser");
            Console.WriteLine("The browser is: " + browser);
            
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
        [AllureIssue("GitHub#1", "https://github.com/unickq/allure-nunit")]
        [AllureTag("NUnit", "Debug")]
        public void ExecuteTests()
        {
            App.UserHelper.Login("qatestvob@appcreative.net", "qwerty");
            Assert.AreEqual("Controlled devices", App.AttributeHelper.GetDevicesPageHeader());
            Assert.AreEqual("Controlled", App.AttributeHelper.GetDevicesPageHeader());
        }
    
        [Test(Description = "Second")]
        [AllureTag("Smoke")]
        public void ExecuteTests2()
        {
            App.UserHelper.Login("qatestvob@appcreative.net", "qrty");
        }
    }
}