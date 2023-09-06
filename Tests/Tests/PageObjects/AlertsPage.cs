using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class AlertsPage : BaseForm
    {
        private Label confirmLabel = new Label(By.Id("confirmResult"), "confirm text label");
        private Label promptResultLabel = new Label(By.Id("promptResult"), "prompt result label");
        private Button alertButton = new Button(By.Id("alertButton"), "alert button");
        private Button confirmAlertButton = new Button(By.Id("confirmButton"), "confirm alert button");
        private Button promtAlertButton = new Button(By.Id("promtButton"), "promt alert button");

        public AlertsPage() : base(By.Id("javascriptAlertsWrapper"), "Alert Page") { }

        public void ClickOnAlertButton() => alertButton.Click();
        public void ClickOnPromptAlertButton() => promtAlertButton.Click();
        public void ClickOnConfirmAlertButton() => confirmAlertButton.Click();
        public string GetConfirmText() => confirmLabel.GetText();
        public string GetResultText() => promptResultLabel.GetText();
    }
}