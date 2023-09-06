using NUnit.Framework;
using Tests.Framework.Utils;

namespace Tests.Tests
{
    [TestFixture, Order(4)]
    public class HandlesTests : BaseTest
    {
        [Test]
        public void HandlesTest()
        {
            NavigateToBrowserWindowsPage();
            TestNewTabFunctionality();
            NavigateToLinksPage();
            TestHomeLinkFunctionality();
        }

        private void NavigateToBrowserWindowsPage()
        {
            Forms.MainPage.ClickOnAlertsFrameWindowsButton();
            Forms.SelectMenuForm.ClickBrowserWindowsButton();
            TestIfFormIsOpen(Forms.BrowserWindowsPage);
        }

        private void TestNewTabFunctionality()
        {
            int numberOfWindowHandlesOpenBefore = WindowHandlesUtils.GetNumberOfWindowHandlesOpen();
            string originalHandle = WindowHandlesUtils.GetCurrentWindowHandle();
            Forms.BrowserWindowsPage.ClickNewTabButton();
            WindowHandlesUtils.SwitchToNextWindowHandle();
            int numberOfWindowHandlesOpenAfter = WindowHandlesUtils.GetNumberOfWindowHandlesOpen();
            TestIfFormIsOpen(Forms.SamplePage);
            Assert.AreEqual(numberOfWindowHandlesOpenBefore + 1, numberOfWindowHandlesOpenAfter, $"{Forms.SamplePage.GetFormName()} is not opened in a new tab");
            WindowHandlesUtils.CloseCurrentWindowHandle();
            WindowHandlesUtils.SwitchToWindowHandle(originalHandle);
        }

        private void NavigateToLinksPage()
        {
            Forms.SelectMenuForm.ClickElementsButton();
            Forms.SelectMenuForm.ClickLinksButton();
            TestIfFormIsOpen(Forms.LinksPage);
        }

        private void TestHomeLinkFunctionality()
        {
            string originalHandle = WindowHandlesUtils.GetCurrentWindowHandle();
            int numberOfWindowHandlesOpenBefore = WindowHandlesUtils.GetNumberOfWindowHandlesOpen();
            Forms.LinksPage.ClickOnHomeLink();
            WindowHandlesUtils.SwitchToNextWindowHandle();
            int numberOfWindowHandlesOpenAfter = WindowHandlesUtils.GetNumberOfWindowHandlesOpen();
            TestIfFormIsOpen(Forms.MainPage);
            Assert.AreEqual(numberOfWindowHandlesOpenBefore + 1, numberOfWindowHandlesOpenAfter, $"{Forms.MainPage.GetFormName()} is not opened in a new tab");
            WindowHandlesUtils.SwitchToWindowHandle(originalHandle);
            TestIfFormIsOpen(Forms.LinksPage);
        }
    }
}