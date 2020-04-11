namespace SeleniumFirst
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
    }
}