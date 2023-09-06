using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class SelectMenuForm : BaseForm
    {
        private Button alertsButton = new Button(By.XPath("//span[text()='Alerts']"), "alerts button");
        private Button nestedFramesButton = new Button(By.XPath("//span[text()='Nested Frames']"), "nested frames button");
        private Button framesButton = new Button(By.XPath("//span[text()='Frames']"), "frames button");
        private Button webTablesButton = new Button(By.XPath("//span[text()='Web Tables']"), "web tables button");
        private Button browserWindowsButton = new Button(By.XPath("//span[text()='Browser Windows']"), "browser windows button");
        private Button linksButton = new Button(By.XPath("//span[text()='Links']"), "links button");
        private Button elementsButton = new Button(By.XPath("//div[contains(@class, 'header-text') and contains(., 'Elements')]"), "elements button");
        public SelectMenuForm() : base(By.ClassName("left-panel"), "Select Menu Form") { }

        public void ClickAlertsButton() => alertsButton.Click();
        public void ClickFramesButton() => framesButton.Click();
        public void ClickNestedFramesButton() => nestedFramesButton.Click();
        public void ClickWebTablesButton() => webTablesButton.Click();
        public void ClickBrowserWindowsButton() => browserWindowsButton.Click();
        public void ClickElementsButton() => elementsButton.Click();
        public void ClickLinksButton() => linksButton.Click();
    }
}