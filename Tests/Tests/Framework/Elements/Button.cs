using OpenQA.Selenium;

namespace Tests.Framework.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) : base(locator, name) { }
    }
}