using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using Tests.Framework.Driver;

namespace Tests.Framework.Utils

{

    public static class AlertUtils

    {

        public static string GetAlertText()

        {

            return GetAlert().Text;

        }




        public static void AcceptAlert()

        {

            GetAlert().Accept();

        }




        public static bool IsAlertPresent()

        {

            IAlert alert = ExpectedConditions.AlertIsPresent().Invoke(Browser.Driver);

            return (alert != null);

        }




        public static void SendKeysToAlertTextField(string textToSend)

        {

            GetAlert().SendKeys(textToSend);

        }




        private static IAlert GetAlert()

        {

            return Browser.Driver.SwitchTo().Alert();

        }

    }

}