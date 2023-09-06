using OpenQA.Selenium;
using Tests.Framework.Driver;
using Tests.Framework.Utils;

namespace Tests.Framework.Elements
{
    public abstract class BaseElement
    {
        protected By uniqueLocator;
        protected string elementName;
        protected IWebDriver driver;
        protected WaitUtils waits;

        public BaseElement(By locator, string name)
        {
            uniqueLocator = locator;
            elementName = name;
            driver = Browser.Driver;
            waits = Browser.Waits;
        }

        public virtual IWebElement GetElement()
        {
            Logger.Info($"Getting {elementName} by locator: {uniqueLocator}");
            return driver.FindElement(uniqueLocator);
        }

        public void Click()
        {
            Logger.Info($"Clicking on {elementName} by locator {uniqueLocator}");
            waits.WaitForElementPresence(uniqueLocator);
            waits.WaitForElementToBeClickable(uniqueLocator);
            GetElement().Click();
        }

        public bool IsElementPresent()
        {
            Logger.Info($"Checking {elementName} presence by locator {uniqueLocator}");
            return waits.WaitForElementPresence(uniqueLocator);
        }

        public string GetText()
        {
            Logger.Info($"Getting {elementName} text by locator {uniqueLocator}");
            return GetElement().Text;
        }
    }
}