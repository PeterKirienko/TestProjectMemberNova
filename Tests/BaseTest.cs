using NUnit.Framework;
using TestProjectMembernova.Core.Driver;

namespace TestProjectMembernova.Tests
{
    public class BaseTest
    {
        [TearDown]
        public void CloseBrowser()
        {
            DriverManager.Instance.Destroy();
        }
    }
}
