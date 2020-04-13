using OpenQA.Selenium;
using SeleniumFirst.managers;

namespace SeleniumFirst.pages
{
    public class LoginPage : Page
    {

        public LoginPage(PageManager pageManager) : base(pageManager)
        {
            
        }
        IWebElement EmailField => Driver.FindElement(By.Id("email"));
        IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        IWebElement LoginBtn => Driver.FindElement(By.XPath("//button[@type='submit']"));
        
        public LoginPage EnterEmail(string value)
        {
            Step($"Enter email ( {value} )", () =>
            {
                 EmailField.SendKeys(value);
            });
            
            return this;
        }
        
        public LoginPage EnterPassword(string value)
        {
            Step($"Enter password ( {value} )", () =>
            {
                PasswordField.SendKeys(value);
            });
            return this;
        }
        
        public LoginPage ClickLoginBtn()
        {
            Step("Click login", () =>
            {
                // Jse.ExecuteScript("arguments[0].click();", LoginBtn);
                LoginBtn.Click();
            });
            return this;
        }
    
    }
}