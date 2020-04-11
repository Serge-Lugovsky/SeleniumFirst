using OpenQA.Selenium;

namespace SeleniumFirst
{
    public class DevicesPage : Page
    {
        public DevicesPage(PageManager pageManager) : base(pageManager)
        {
        }
        IWebElement Header => Driver.FindElement(By.XPath("//div[@class='titleText']/p"));
        public string GetPageHeader()
        {
            Step("Get page header");
            return Header.Text;
        }
    
    }
}