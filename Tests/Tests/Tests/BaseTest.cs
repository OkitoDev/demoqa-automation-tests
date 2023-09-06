using NUnit.Framework;
using Tests.Framework.Driver;
using Tests.Framework.Elements;
using Tests.Framework.Utils;
using Tests.PageObjects;

namespace Tests.Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        protected string url;
        protected Forms Forms;

        [SetUp]
        public void SetUp()
        {
            url = SettingReader.GetUrl();
            Forms = new Forms();
            Browser.Maximize();
            Logger.Info($"Navigating to the url: {url}");
            Browser.GoToUrl(url);
            TestIfFormIsOpen(Forms.MainPage);
        }

        [TearDown]
        public void OneTimeTearDown()
        {
            Browser.CloseBrowser();
        }

        protected void TestIfFormIsOpen(BaseForm form)
        {
            Assert.IsTrue(form.IsFormOpen(), $"{form.GetFormName()} is not opened");
        }

        protected void TestIfFormHasClosed(BaseForm form)
        {
            Assert.IsTrue(form.HasFormClosed(), $"{form.GetFormName()} was not closed");
        }
    }
}