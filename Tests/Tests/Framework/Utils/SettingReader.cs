using System.Configuration;

namespace Tests.Framework.Utils
{
    public static class SettingReader
    {
        private static Configuration config;

        private static string GetConfigValueForKey(string key)
        {
            if (config == null)
            {
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = "App.config";
                config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
            }

            return config.AppSettings.Settings[key].Value;
        }

        public static string GetUrl() => GetConfigValueForKey("url");
        public static int GetExplicitWaitTime() => int.Parse(GetConfigValueForKey("explicitWaitTime"));
        public static string GetBrowserName() => GetConfigValueForKey("browser");
        public static string GetChromeConfig() => GetConfigValueForKey("chromeOptions");
        public static string GetFirefoxConfig() => GetConfigValueForKey("firefoxOptions");
    }
}