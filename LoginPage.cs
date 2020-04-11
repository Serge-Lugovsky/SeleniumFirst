using System;
using Allure.Commons;
using NUnit.Allure.Core;
using OpenQA.Selenium;

namespace SeleniumFirst
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
                LoginBtn.Click();
            });
            return this;
        }
    
    }
}