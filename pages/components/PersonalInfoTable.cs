using OpenQA.Selenium;

namespace TestProjectMembernova.pages.components
{
    public class PersonalInfoTable : BasePage
    {
        private readonly By _memberShipTableRowsLocator = By.XPath("//*[@class='odd']");
        private readonly By _memberShipStatusLocator = By.XPath("//*[@class='odd']//*[contains(@class,'label-status')]");

        public int GetMemberShipTableRowsCount()
        {
            return actions.FindElements(_memberShipTableRowsLocator, 10).Count;
        }
        public string GetMemberShipStatus()
        {
            return actions.FindElement(_memberShipStatusLocator, 10).Text;
        }
    }
}
