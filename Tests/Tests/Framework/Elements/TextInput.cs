using OpenQA.Selenium;
using Tests.Framework.Utils;

namespace Tests.Framework.Elements
{
    public class TextInput : BaseElement
    {
        private By formLocator;

        public TextInput(By locator, string name, By formLocator = null) : base(locator, name)
        {
            this.formLocator = formLocator;
        }

        public override IWebElement GetElement()
        {
            if (formLocator == null)
            {
                return base.GetElement();
            }
            else
            {
                Logger.Info($"Getting {elementName} by locator {uniqueLocator} in form with locator {formLocator}");
                return driver.FindElement(formLocator).FindElement(uniqueLocator);
            }
        }

        public void SendText(string text) => GetElement().SendKeys(text);
    }
}