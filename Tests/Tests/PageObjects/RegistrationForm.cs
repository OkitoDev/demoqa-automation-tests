using OpenQA.Selenium;
using Tests.Framework.Elements;
using Tests.Models;

namespace Tests.PageObjects
{
    public class RegistrationForm : BaseForm
    {
        private static By formLocator = By.Id("userForm");
        private Form registrationForm = new Form(formLocator, "Registration Form");
        private TextInput firstNameInput = new TextInput(By.Id("firstName"), "First Name Input", formLocator);
        private TextInput lastNameInput = new TextInput(By.Id("lastName"), "First Name Input", formLocator);
        private TextInput userEmailInput = new TextInput(By.Id("userEmail"), "First Name Input", formLocator);
        private TextInput ageInput = new TextInput(By.Id("age"), "First Name Input", formLocator);
        private TextInput salaryInput = new TextInput(By.Id("salary"), "First Name Input", formLocator);
        private TextInput departmentInput = new TextInput(By.Id("department"), "First Name Input", formLocator);

        public RegistrationForm() : base(formLocator, "Registration form") { }

        public void FillRegistrationFormWithData(UserDataModel userData)
        {
            firstNameInput.SendText(userData.FirstName);
            lastNameInput.SendText(userData.LastName);
            userEmailInput.SendText(userData.Email);
            ageInput.SendText(userData.Age.ToString());
            salaryInput.SendText(userData.Salary.ToString());
            departmentInput.SendText(userData.Department);
        }

        public void SubmitRegistrationForm() => registrationForm.Submit();
    }
}