using System.Linq;
using Tests.Framework.Driver;

namespace Tests.Framework.Utils
{
    public static class WindowHandlesUtils
    {
        public static int GetNumberOfWindowHandlesOpen()
        {
            return Browser.Driver.WindowHandles.Count;
        }

        public static void CloseCurrentWindowHandle()
        {
            Browser.Driver.Close();
        }

        public static string GetCurrentWindowHandle()
        {
            return Browser.Driver.CurrentWindowHandle;
        }

        public static void SwitchToWindowHandle(string windowHandle)
        {
            Browser.Driver.SwitchTo().Window(windowHandle);
        }

        public static void SwitchToNextWindowHandle()
        {
            string newHandle = Browser.Driver.WindowHandles.FirstOrDefault(handle => handle != Browser.Driver.CurrentWindowHandle);
            SwitchToWindowHandle(newHandle);
        }
    }
}