namespace Logic
{
    using System;

    public static class Logger
    {
        private static readonly string LOG_CONFIG_FILE = @"Logic.config";

        private static readonly log4net.ILog _log = GetLogger(typeof(Logger));

        public static log4net.ILog GetLogger(Type type)
        {
            return log4net.LogManager.GetLogger(type);
        }

        public static void Info(object message)
        {
            SetLog4NetConfiguration();
            _log.Info(message);
        }

        private static void SetLog4NetConfiguration()
        {
            System.Xml.XmlDocument log4netConfig = new System.Xml.XmlDocument();
            log4netConfig.Load(System.IO.File.OpenRead(LOG_CONFIG_FILE));

            var repo = log4net.LogManager.CreateRepository(
                System.Reflection.Assembly.GetEntryAssembly(), typeof(log4net.Repository.Hierarchy.Hierarchy));

            log4net.Config.XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
        }
    }
}