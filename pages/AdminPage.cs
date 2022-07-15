using OpenQA.Selenium;
using TestProjectMembernova.pages.components;

namespace TestProjectMembernova.pages
{
    public class AdminPage : BasePage
    {
        private readonly By _userAvatarLocator = By.Id("dropdownUserMenu");
        private readonly By _profileLinkLocator = By.XPath("//li[@class='user-profile']/a");
        private readonly By _membershipTabLinkLocator = By.XPath("//a[contains(text(),'Membership')]");

        public AdminPage OpenUserProfile()
        {
            actions.ClickElement(_userAvatarLocator, 10); 
            actions.ClickElement(_profileLinkLocator, 10);
            return this;
        }

        public MembershipTab GoToMembershipTab()
        {
            actions.ClickElement(_membershipTabLinkLocator, 10);
            return new MembershipTab();
        }
    }
}
