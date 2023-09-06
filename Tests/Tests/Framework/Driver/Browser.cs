using OpenQA.Selenium;
using Tests.Framework.Utils;

namespace Tests.Framework.Driver
{
    public static class Browser
    {
        private static WaitUtils waits;
        private static IWebDriver driver;

        public static WaitUtils Waits
        {
            get
            {
                if (waits == null)
                {
                    waits = new WaitUtils();
                }

                return waits;
            }
        }

        public static IWebDriver Driver
        {
            get
            {
                if (driver == null)
                {
                    driver = BrowserFactory.InitBrowser();
                }

                return driver;
            }
        }

        public static void CloseBrowser()
        {
            Driver.Quit();
            driver = null;
            waits = null;
        }

        public static void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static void Maximize()
        {
            Driver.Manage().Window.Maximize();
        }
    }
}