using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class FramesPage : BaseForm
    {
        private Label frameTextLabel = new Label(By.Id("sampleHeading"), "frame text Label");

        public FramesPage() : base(By.Id("frame2Wrapper"), "Frames Page") { }

        public string GetFrameText() => frameTextLabel.GetText();
    }
}