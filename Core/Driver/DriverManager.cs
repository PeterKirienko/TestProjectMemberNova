using OpenQA.Selenium;
using System.Threading;

namespace TestProjectMembernova.Core.Driver
{
    public class DriverManager
    {
        private static readonly ThreadLocal<DriverManager> threadLocal =
                new ThreadLocal<DriverManager>(() => new DriverManager());

        private static readonly object ThreadLock = new object();
        public static DriverManager Instance { get { return threadLocal.Value; } }
        public IWebDriver CurrentDriver { get => GetDriver(); }

        private IWebDriver _driver = null;

        protected IWebDriver GetDriver()
        {
            lock (ThreadLock)
            {
                if (_driver == null)
                {
                    _driver =
                        DriverFactory.GetDriver();
                }
                return _driver;
            }
        }

        public void Destroy()
        {
            if (_driver != null)
            {
                CurrentDriver.Close();
                CurrentDriver.Quit();
                _driver = null;
            }
        }

        ~DriverManager()
        {
            Destroy();
        }
    }
}
