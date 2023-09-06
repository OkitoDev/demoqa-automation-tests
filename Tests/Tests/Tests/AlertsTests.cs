using NUnit.Framework;
using Tests.Framework.Utils;
using Tests.Utils;

namespace Tests.Tests
{
    [TestFixture, Order(1)]
    public class AlertsTests : BaseTest
    {
        [Test]
        public void AlertsTest()
        {
            NavigateToAlertsPage();
            TestNormalAlert();
            TestConfirmAlert();
            TestPromptAlert();
        }

        private void NavigateToAlertsPage()
        {
            Forms.MainPage.ClickOnAlertsFrameWindowsButton();
            Forms.SelectMenuForm.ClickAlertsButton();
            TestIfFormIsOpen(Forms.AlertsPage);
        }

        private void TestNormalAlert()
        {
            Forms.AlertsPage.ClickOnAlertButton();
            Assert.AreEqual("You clicked a button", AlertUtils.GetAlertText(), "Alert text does not match the expected text");
            AlertUtils.AcceptAlert();
            Assert.IsFalse(AlertUtils.IsAlertPresent(), "Alert was not closed");
        }

        private void TestConfirmAlert()
        {
            Forms.AlertsPage.ClickOnConfirmAlertButton();
            Assert.AreEqual("Do you confirm action?", AlertUtils.GetAlertText(), "Alert text does not match the expected text");
            AlertUtils.AcceptAlert();
            Assert.IsFalse(AlertUtils.IsAlertPresent(), "Alert was not closed");
            Assert.AreEqual("You selected Ok", Forms.AlertsPage.GetConfirmText(), "Confirm text does not match the expected text");
        }

        private void TestPromptAlert()
        {
            Forms.AlertsPage.ClickOnPromptAlertButton();
            Assert.AreEqual("Please enter your name", AlertUtils.GetAlertText(), "Alert text does not match the expected text");
            string randomString = RandomUtils.GetRandomString(15);
            AlertUtils.SendKeysToAlertTextField(randomString);
            AlertUtils.AcceptAlert();
            Assert.IsFalse(AlertUtils.IsAlertPresent(), "Alert was not closed");
            Assert.AreEqual("You entered " + randomString, Forms.AlertsPage.GetResultText(), "Result text does not match the expected text");
        }
    }
}