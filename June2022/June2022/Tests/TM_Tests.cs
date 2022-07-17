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

        [Test]
        public void CreateTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);


        }

        [Test]
        public void EditTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTmTest()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseRunTest()
        {


        }

    }
}
