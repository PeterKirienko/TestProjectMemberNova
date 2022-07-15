using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace TestProjectMembernova.Core.Driver
{
    class DriverFactory
    {
        private static readonly ThreadLocal<DriverFactory> threadLocal =
                new ThreadLocal<DriverFactory>(() => new DriverFactory());

        public static DriverFactory Instance { get { return threadLocal.Value; } }
        public static IWebDriver GetDriver()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            return driver;
        }
    }
}
