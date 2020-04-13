using Allure.Commons;
using OpenQA.Selenium;
using SeleniumFirst.managers;

namespace SeleniumFirst.utils
{
    public static class ScreenshotListener
    {
        public static void SaveScreenshot(ApplicationManager app)
        {
            ITakesScreenshot screenshot = (ITakesScreenshot) app.Driver;

            AllureLifecycle.Instance.AddAttachment(
                        "Screenshot", 
                        "image/jpg", 
                        screenshot.GetScreenshot().AsByteArray,
                        ".jpg"
            );
        }

    }
}