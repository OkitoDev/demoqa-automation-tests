using OpenQA.Selenium;

namespace Tests.Framework.Elements
{
    public class WebTableRow : BaseElement
    {
        public WebTableRow(By locator, string name) : base(locator, name) { }

        public bool DoesCellValueExist(string cellValue)
        {
            return GetElement().FindElements(By.XPath($"//*[text()='{cellValue}']")).Count > 0;
        }
    }
}