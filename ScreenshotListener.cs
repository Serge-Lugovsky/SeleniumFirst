using Allure.Commons;
using OpenQA.Selenium;

namespace SeleniumFirst
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