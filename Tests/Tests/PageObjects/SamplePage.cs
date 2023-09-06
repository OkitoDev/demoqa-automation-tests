using OpenQA.Selenium;
using Tests.Framework.Elements;

namespace Tests.PageObjects
{
    public class SamplePage : BaseForm
    {
        public SamplePage() : base(By.Id("sampleHeading"), "Sample page") { }
    }
}