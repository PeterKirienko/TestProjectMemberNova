using NUnit.Framework;
using TestProjectMembernova.Core.Driver;
using TestProjectMembernova.pages;
using TestProjectMembernova.Tests;
namespace TestProjectMembernova
{
    public class TestSubscriptions : BaseTest
    {
        private readonly LoginPage _loginPage = new LoginPage();
               
        [Test]
        public void TestMemberSubscription()
        {
            var personalInfoTable = _loginPage.Login().OpenUserProfile().GoToMembershipTab().GetPersonalInfoTable();
            Assert.Multiple(() =>
            {
                Assert.IsTrue(personalInfoTable.GetMemberShipTableRowsCount() == 1, "You don't have any membership");
                Assert.AreEqual(personalInfoTable.GetMemberShipStatus(), "Active", "Your membership is not active");
            });
        }
     }
}