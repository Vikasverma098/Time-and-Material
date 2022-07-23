using June2022.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace June2022.StepDefinition
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommanDriver
    {
        EmployeePage employeePageObj = new EmployeePage();
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();

        [Given(@"I logged inti TurnUp Portal successfully")]
        public void GivenILoggedIntiTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to employee's feature page")]
        public void WhenINavigateToEmployeesFeaturePage()
        {
            homePageObj.GoToEmployeePage(driver);
        }

        [When(@"I create a new employee record")]
        public void ThenICreateANewEmployeeRecord()
        {
            employeePageObj.CreateEmployee(driver);
        }

        [Then(@"the record sholud be created successfully")]
        public void ThenTheRecordSholudBeCreatedSuccessfully()
        {
            string newName = employeePageObj.GetName(driver);
            string newUserName = employeePageObj.GetUserName(driver);

            Assert.That(newName == "HANNA", "Actual name and created name do not match");
            Assert.That(newUserName == "HANNA HARRY", "Actual username and created username do not match");
        }

        [When(@"I Update '([^']*)' and '([^']*)' of an employee's record")]
        public void WhenIUpdateAndOfAnEmployeesRecord(string s0, string s1)
        {
            employeePageObj.EditEmployee(driver,s0, s1);
        }

        [Then(@"The record should have '([^']*)' and '([^']*)' Updated")]
        public void ThenTheRecordShouldHaveAndUpdated(string s0, string s1)
        {
            string newName = employeePageObj.GetName(driver);
            string newUserName = employeePageObj.GetUserName(driver);


            Assert.That(newName == s0, "Actual name and edited name do not match");
            Assert.That(newUserName == s1, "Actual username and edited username do not match");

        }

        [When(@"I deleted an existing record")]
        public void WhenIDeletedAnExistingRecord()
        {
            employeePageObj.DeleteEmployee(driver);
        }

        [Then(@"the record sholud be deleted sucessfully")]
        public void ThenTheRecordSholudBeDeletedSucessfully()
        {
            string deletedName = employeePageObj.GetDeletedName(driver);
            string deletedUserName = employeePageObj.GetDeletedUserName(driver);

            Assert.That(deletedName != "Las", "Name not deleted successfully, Test Fail");
            Assert.That(deletedUserName != "Vegas", "UserName not deleted successfully, Test fail");
        }








    }
}
