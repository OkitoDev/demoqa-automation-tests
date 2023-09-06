using OpenQA.Selenium;
using Tests.Framework.Driver;
using Tests.Framework.Utils;

namespace Tests.Framework.Elements
{
    public abstract class BaseForm
    {
        protected By uniqueFormLocator;
        protected string formName;
        protected IWebDriver driver;
        protected WaitUtils waits;
        
        public BaseForm(By locator, string name)
        {
            uniqueFormLocator = locator;
            formName = name;
            driver = Browser.Driver;
            waits = Browser.Waits;
        }

        public bool IsFormOpen()
        {
            Logger.Info($"Checking if {GetFormName()} is open");
            return waits.WaitForElementPresence(uniqueFormLocator);
        }

        public bool HasFormClosed()
        {
            Logger.Info($"Checking if {GetFormName()} has closed");
            return waits.WaitForElementToDisappear(uniqueFormLocator);
        }

        public string GetFormName()
        {
            return formName;
        }
    }
}