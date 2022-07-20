using June2022.Utilities;
using NUnit.Framework;


namespace June2022.Tests
{


    [TestFixture]
    [Parallelizable]
    public class TM_Test : CommanDriver
    {
        // Page Object Initilisation.--------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Test,Order(1), Description("Check if user is able to create Material record with valid data")]
        public void CreateTmTest()
        {           
            homePageObj.GoToTMPage(driver);
            tmPageObj.CreateTM(driver);
        }

        [Test,Order(2), Description("Check if user is able to Edit Material record with valid data")]
        public void EditTmTest()
        {            
            homePageObj.GoToTMPage(driver);            
            tmPageObj.EditTM(driver);
        }

        [Test,Order(3), Description("Check if user is able to delete time record.")]
        public void DeleteTmTest()
        {           
            homePageObj.GoToTMPage(driver);           
            tmPageObj.DeleteTM(driver);
        }

        

    }
}
