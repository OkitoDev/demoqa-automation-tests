using OpenQA.Selenium;

namespace Tests.Framework.Elements
{
    public class Form : BaseElement
    {
        public Form(By locator, string name) : base(locator, name) { }

        public void Submit()
        {
            GetElement().Submit();
        }
    }
}