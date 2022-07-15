using OpenQA.Selenium;

namespace TestProjectMembernova.pages.components
{
    public class MembershipTab : BasePage
    {
        public PersonalInfoTable GetPersonalInfoTable()
        {
            return new PersonalInfoTable();
        }
    }
}
