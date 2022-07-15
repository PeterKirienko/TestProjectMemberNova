using OpenQA.Selenium;
using TestProjectMembernova.Core.Helpers.Config;

namespace TestProjectMembernova.pages
{
   public  class LoginPage:BasePage
    {
        private readonly By _loginFieldLocator = By.Id("UserName");
        private readonly By _passwordFieldLocator = By.Id("Password");
        private readonly By _loginButtonLocator = By.Name("button");

        public AdminPage Login() {
            actions.Navigate(ConfigurationService.Instance.Config.Url);
            actions.SendKeys(_loginFieldLocator, ConfigurationService.Instance.Config.Login, 10);
            actions.SendKeys(_passwordFieldLocator, ConfigurationService.Instance.Config.Password, 10);
            actions.ClickElement(_loginButtonLocator, 10);
            return new AdminPage();
        }
    }
}
