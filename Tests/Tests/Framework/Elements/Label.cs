using OpenQA.Selenium;

namespace Tests.Framework.Elements
{
    public class Label : BaseElement
    {
        public Label(By locator, string name) : base(locator, name) { }
    }
}