using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using SeleniumFirst.managers;

namespace SeleniumFirst.pages
{
    public class DevicesPage : Page
    {
        public DevicesPage(PageManager pageManager) : base(pageManager)
        {
        }
        IWebElement Header => Driver.FindElement(By.XPath("//div[@class='titleText']/p"));
        IList<IWebElement> TopMenuTabs => Driver.FindElements(By.XPath("//div[@class='topMenuInner']/a"));
        public string GetPageHeader()
        {
            Step("Get page header");
            return Header.Text;
        }

        public IList<string> GetTopMenuTabsNames()
        {
            Step("Get top menu tabs names");
            Thread.Sleep(5000);
            return new List<string>(from var in TopMenuTabs select var.Text);;
        }
    
    }
}