using System.Linq;
using OpenQA.Selenium;
using Tests.Framework.Elements;
using Tests.Models;

namespace Tests.PageObjects
{
    public class WebTablesPage : BaseForm
    {
        private WebTableRow lastUserRow = new WebTableRow(By.XPath("(//div[@class='action-buttons'])[last()]/../.."), "Last user row");
        private Button addNewRecordButton = new Button(By.Id("addNewRecordButton"), "Add New Record Button");
        private Button lastRecordDeleteButton = new Button(By.XPath("//span[contains(@id, 'delete-record')][last()]"), "Last record delete button");

        public WebTablesPage() : base(By.ClassName("web-tables-wrapper"), "Web Tables Page") { }

        public void ClickAddNewRecordButton() => addNewRecordButton.Click();
        public int GetNumberOfUserRows() => driver.FindElements(By.ClassName("action-buttons")).Count;
        public bool WasUserDataAddedToTheWebTable(UserDataModel userData) => userData.ReturnAsListOfStrings().All(data => lastUserRow.DoesCellValueExist(data));
        public void DeleteLastUserTest() => lastRecordDeleteButton.Click();
    }
}