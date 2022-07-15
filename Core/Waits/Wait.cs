using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TestProjectMembernova.Core.Driver;

namespace TestProjectMembernova.Core.Waits
{
    public class Wait
    {
		private readonly WebDriverWait _wait;
		private readonly By _locator;

        public Wait(By locator, int time)
		{
			_locator = locator;
			_wait = new WebDriverWait(DriverManager.Instance.CurrentDriver, TimeSpan.FromSeconds(time));
		}

		public void ForVisible()
		{
			_wait.Until(ExpectedConditions.ElementIsVisible(_locator));
		}

		public void ForClickable()
		{
			_wait.Until(ExpectedConditions.ElementToBeClickable(_locator));
		}
	}
}
