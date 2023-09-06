using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class LinksPage : BaseForm
    {
        private Label homeLink = new Label(By.Id("simpleLink"), "home link");
        public LinksPage() : base(By.Id("linkWrapper"), "Links Page") { }

        public void ClickOnHomeLink() => homeLink.Click();
    }
}