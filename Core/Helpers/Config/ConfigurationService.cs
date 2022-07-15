using System.Threading;

namespace TestProjectMembernova.Core.Helpers.Config
{
    public class ConfigurationService
    {
        private static readonly ThreadLocal<ConfigurationService> threadLocal =
                new ThreadLocal<ConfigurationService>(() => new ConfigurationService());
        private static readonly object ThreadLock = new object();
        public static ConfigurationService Instance { get { return threadLocal.Value; } }
        public IConfig Config { get => GetConfig(); }

        private IConfig _config = null;

        protected IConfig GetConfig()
        {
            lock (ThreadLock)
            {
                if (_config == null)
                {
                    _config = ConfigurationFactory.GetSettingsFromConfig();
                }
                return _config;
            }
        }
    }
}
