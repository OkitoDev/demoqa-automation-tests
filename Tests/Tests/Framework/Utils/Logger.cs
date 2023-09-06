using log4net;
using log4net.Config;

[assembly: XmlConfigurator(ConfigFile = "App.config", Watch = true)]

namespace Tests.Framework.Utils
{
    public static class Logger
    {
        private static ILog log = LogManager.GetLogger(typeof(Logger));
        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Debug(string message)
        {
            log.Debug(message);
        }

        public static void Warn(string message)
        {
            log.Warn(message);
        }

        public static void Error(string message)
        {
            log.Error(message);
        }
    }
}