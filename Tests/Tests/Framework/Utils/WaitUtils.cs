using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using Tests.Framework.Driver;

namespace Tests.Framework.Utils
{
    public class WaitUtils
    {
        private static WebDriverWait wait;

        public WaitUtils()
        {
            wait = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(SettingReader.GetExplicitWaitTime()));
        }

        public void WaitForElementToBeClickable(By uniqueLocator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(uniqueLocator));
        }

        public bool WaitForElementPresence(By uniqueLocator)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(uniqueLocator)).Displayed;
        }

        public bool WaitForElementToDisappear(By uniqueLocator)
        {
            return wait.Until(ExpectedConditions.InvisibilityOfElementLocated(uniqueLocator));
        }
    }
}