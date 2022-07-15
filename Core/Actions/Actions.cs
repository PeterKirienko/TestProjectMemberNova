using OpenQA.Selenium;
using System.Collections.Generic;
using TestProjectMembernova.Core.Driver;
using TestProjectMembernova.Core.Waits;

namespace TestProjectMembernova.Core.Actions
{
    public class Actions
    {
        public void Navigate(string url)

        {
            DriverManager.Instance.CurrentDriver.Navigate().GoToUrl(url);
        }

        public void ClickElement(By locator, int secondsToWait)
        {
            new Wait(locator, secondsToWait).ForClickable();
            FindElement(locator, secondsToWait).Click();
        }

        public IWebElement FindElement(By locator, int secondsToWait)
        {
            new Wait(locator, secondsToWait).ForVisible();
            return DriverManager.Instance.CurrentDriver.FindElement(locator);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator, int secondsToWait)
        {
            new Wait(locator, secondsToWait).ForVisible();
            return DriverManager.Instance.CurrentDriver.FindElements(locator);
        }

        public void SendKeys(By locator, string text, int secondsToWait)
        {
            FindElement(locator, secondsToWait).SendKeys(text);
        }
    }
}
