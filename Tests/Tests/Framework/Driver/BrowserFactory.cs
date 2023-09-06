using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Tests.Framework.Utils;

namespace Tests.Framework.Driver
{
    public static class BrowserFactory
    {
        public static IWebDriver InitBrowser()
        {
            string browserName = SettingReader.GetBrowserName();

            switch (browserName.ToLower())
            {
                case "chrome":
                    ChromeOptions chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument(SettingReader.GetChromeConfig());
                    return new ChromeDriver(chromeOptions);
                case "firefox":
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument(SettingReader.GetFirefoxConfig());
                    return new FirefoxDriver(firefoxOptions);
                default:
                    throw new Exception("Invalid browser name");
            }
        }
    }
}