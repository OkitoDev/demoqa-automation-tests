using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class BrowserWindowsPage : BaseForm
    {
        private Button newTabButton = new Button(By.Id("tabButton"), "New tab button");
        public BrowserWindowsPage() : base(By.Id("browserWindows"), "Browser Windows Page") { }

        public void ClickNewTabButton() => newTabButton.Click();
    }
}