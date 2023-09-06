using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class NestedFramesPage : BaseForm
    {
        private Label bodyLabel = new Label(By.XPath("//body"), "body label");
        private Label paragraphLabel = new Label(By.TagName("p"), "paragraph label");

        public NestedFramesPage() : base(By.XPath("//div[@class='main-header' and text()='Nested Frames']"), "Nested Frames Page") { }

        public string GetBodyLabelText() => bodyLabel.GetText();
        public string GetParagraphText() => paragraphLabel.GetText();
    }
}