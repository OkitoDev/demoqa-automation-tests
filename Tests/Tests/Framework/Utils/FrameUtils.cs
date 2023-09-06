using OpenQA.Selenium;
using Tests.Framework.Driver;

namespace Tests.Framework.Utils
{
    public static class FrameUtils
    {
        public static void SwitchToFrame(string frameName)
        {
            Browser.Driver.SwitchTo().Frame(frameName);
        }

        public static void SwitchToFrame(int frameIndex)
        {
            Browser.Driver.SwitchTo().Frame(frameIndex);
        }

        public static void SwitchToFrame(IWebElement webElement)
        {
            Browser.Driver.SwitchTo().Frame(webElement);
        }

        public static void SwitchToDefaultContent()
        {
            Browser.Driver.SwitchTo().DefaultContent();
        }
    }
}