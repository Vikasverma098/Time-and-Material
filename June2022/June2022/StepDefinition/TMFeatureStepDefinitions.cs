using June2022.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace June2022.StepDefinition
{
    [Binding]
    public class TMFeatureStepDefinitions : CommanDriver
    {


        LoginPage LoginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();


        [AfterTestRun]
        public static void AfterWebFeature(IWebDriver driver)
        {
            driver.Quit();
        }


        [Given(@"I logged into TurnUp portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();            
            LoginPageObj.LoginActions(driver);
            
        }


        [When(@"I navigate to time and meterial page")]
        public void WhenINavigateToTimeAndMeterialPage()
        {           
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new material record")]
        public void WhenICreateANewMaterialRecord()
        {            
            tmPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {

            string newCode = tmPageObj.GetCode(driver);
            string newDescription = tmPageObj.GetDescription(driver);
            string newPrice = tmPageObj.GetPrice(driver);

            Assert.That(newCode == "Verma", "Actual code and expected code do not match");
            Assert.That(newDescription == "harry", "Actual description and expected description do not match");
            Assert.That(newPrice == "$15.00", "Actual price and expected price do not match");
        }
        


        [When(@"I update '([^']*)', '([^']*)' and '([^']*)' of an existing material record")]
        public void WhenIUpdateAndOfAnExistingMaterialRecord(string p0, string p1, string p2)
        {
            tmPageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"the record should have the '([^']*)', '([^']*)' and '([^']*)' updated")]
        public void ThenTheRecordShouldHaveTheAndUpdated(string p0, string p1, string p2)
        {
            string editedCode = tmPageObj.GeteditedCode(driver);
            string editedDescription = tmPageObj.GeteditedDescription(driver);
            string editedPrice = tmPageObj.GeteditedPrice(driver);

            Assert.That(editedCode == p0, "Actual code and edited code do not match");
            Assert.That(editedDescription == p1, "Actual description and expected description do not match");
            Assert.That(editedPrice == p2, "Actual price and expected price do not match");

        }

        [When(@"I delete an existing record")]
        public void WhenIDeleteAnExistingRecord()
        {
            tmPageObj.DeleteTM(driver);
        }

        [Then(@"The record should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully()
        {
           string deletedCode = tmPageObj.GeteditedCode(driver);
           string deletedDescription = tmPageObj.GeteditedDescription(driver);
           string deletedPrice = tmPageObj.GeteditedPrice(driver);


            Assert.That(deletedCode != "Pen", "record Code not deleted successfully");
            Assert.That(deletedDescription != "Blue", "record description not deleted successfully");
            Assert.That(deletedPrice != "$5.00", "record price not deleted successfully");
        }

    }
}
