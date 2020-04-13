using System.Collections.Generic;
using SeleniumFirst.managers;

namespace SeleniumFirst.helpers
{
    public class AttributeHelper : PageManager
    {
        public AttributeHelper(ApplicationManager applicationManager) : base(applicationManager.Driver)
        {
            
        }
        
        public string GetDevicesPageHeader()
        {
            Step("Get page header");
            return DevicesPage.GetPageHeader();
        }        

        public IList<string> GetTopMenuTabsNames()
        {
            Step("Get top menu tabs names");
            return DevicesPage.GetTopMenuTabsNames();
        }
    }
}