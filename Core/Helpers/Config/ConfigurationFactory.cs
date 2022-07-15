using Microsoft.Extensions.Configuration;
using System.Threading;

namespace TestProjectMembernova.Core.Helpers.Config
{
    class ConfigurationFactory
    {
        private static readonly ThreadLocal<ConfigurationFactory> threadLocal =
                new ThreadLocal<ConfigurationFactory>(() => new ConfigurationFactory());
        public static ConfigurationFactory Instance { get { return threadLocal.Value; } }
        public static IConfig GetSettingsFromConfig()
        {
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
            return configuration.Get<Config>();
        }
    }
}
