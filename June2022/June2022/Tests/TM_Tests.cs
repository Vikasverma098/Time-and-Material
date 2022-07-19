using June2022.Utilities;
using NUnit.Framework;


namespace June2022.Tests
{


    [TestFixture]
    public class TM_Test : CommanDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }

        [Test,Order(1), Description("Check if user is able to create Material record with valid data")]
        public void CreateTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);


        }

        [Test,Order(2), Description("Check if user is able to Edit Material record with valid data")]
        public void EditTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test,Order(3), Description("Check if user is able to delete time record.")]
        public void DeleteTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseRunTest()
        {
            // To close chrome browser
            Thread.Sleep(5000);
            driver.Close();

        }

    }
}
