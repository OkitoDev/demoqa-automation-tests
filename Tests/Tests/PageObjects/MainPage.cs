using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class MainPage : BaseForm
    {
        private Label alertsFrameWindowsButton = new Label(By.XPath("//h5[text()='Alerts, Frame & Windows']"), "Alerts, Frame and Windows Button");
        private Label elementsButton = new Label(By.XPath("//h5[text()='Elements']"), "Elements Button");

        public MainPage() : base(By.ClassName("home-content"), "Main Page") { }

        public void ClickOnAlertsFrameWindowsButton() => alertsFrameWindowsButton.Click();
        public void ClickOnElementsButton() => elementsButton.Click();
    }
}