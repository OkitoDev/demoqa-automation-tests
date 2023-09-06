using NUnit.Framework;
using Tests.Framework.Utils;

namespace Tests.Tests
{
    [TestFixture, Order(2)]
    public class FrameTests : BaseTest
    {
        [Test]
        public void FrameTest()
        {
            NavigateToNestedFramesPage();
            TestNestedFramesPage();
            NavigateToFramesPage();
            TestFramesPage();
        }

        private void NavigateToNestedFramesPage()
        {
            Forms.MainPage.ClickOnAlertsFrameWindowsButton();
            Forms.SelectMenuForm.ClickNestedFramesButton();
            TestIfFormIsOpen(Forms.NestedFramesPage);
        }

        private void TestNestedFramesPage()
        {
            FrameUtils.SwitchToFrame("frame1");
            Assert.AreEqual("Parent frame", Forms.NestedFramesPage.GetBodyLabelText(), "Parent frame text is not present on the site");
            FrameUtils.SwitchToFrame(0);
            Assert.AreEqual("Child Iframe", Forms.NestedFramesPage.GetParagraphText(), "Child Iframe text is not present on the site");
        }

        private void NavigateToFramesPage()
        {
            FrameUtils.SwitchToDefaultContent();
            Forms.SelectMenuForm.ClickFramesButton();
            TestIfFormIsOpen(Forms.FramesPage);
        }

        private void TestFramesPage()
        {
            FrameUtils.SwitchToFrame("frame1");
            string firstFrameText = Forms.FramesPage.GetFrameText();
            FrameUtils.SwitchToDefaultContent();
            FrameUtils.SwitchToFrame("frame2");
            string secondFrameText = Forms.FramesPage.GetFrameText();
            Assert.AreEqual(firstFrameText, secondFrameText, "First and second frame texts are not equal");
        }
    }
}