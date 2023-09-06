using System.Collections.Generic;
using NUnit.Framework;
using Tests.Models;
using Tests.TestData;

namespace Tests.Tests
{
    [TestFixture, Order(3)]
    public class WebTableTests : BaseTest
    {
        private static List<UserDataModel> UserDataModels() => TestDataAccess.GetUserData();

        [Test]
        [TestCaseSource(nameof(UserDataModels))]
        public void WebTableTest(UserDataModel userData)
        {
            NavigateToWebTablesPage();
            AddNewUserToWebTable(userData);
            DeleteLastUserFromWebTable();
        }

        private void NavigateToWebTablesPage()
        {
            Forms.MainPage.ClickOnElementsButton();
            Forms.SelectMenuForm.ClickWebTablesButton();
            TestIfFormIsOpen(Forms.WebTablesPage);
        }

        private void AddNewUserToWebTable(UserDataModel userData)
        {
            Forms.WebTablesPage.ClickAddNewRecordButton();
            TestIfFormIsOpen(Forms.RegistrationForm);
            Forms.RegistrationForm.FillRegistrationFormWithData(userData);
            Forms.RegistrationForm.SubmitRegistrationForm();
            Assert.IsTrue(Forms.WebTablesPage.WasUserDataAddedToTheWebTable(userData) ,"User was not properly added to the web table");
            TestIfFormHasClosed(Forms.RegistrationForm);
        }

        private void DeleteLastUserFromWebTable()
        {
            int numberOfUsersInTableBefore = Forms.WebTablesPage.GetNumberOfUserRows();
            Forms.WebTablesPage.DeleteLastUserTest();
            int numberOfUsersInTableAfter = Forms.WebTablesPage.GetNumberOfUserRows();
            Assert.IsTrue(numberOfUsersInTableAfter == numberOfUsersInTableBefore - 1, "User was not deleted properly from the web table");
        }
    }
}