using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace June2022.Utilities
{
    public class CommanDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            // To close chrome browser
            Thread.Sleep(5000);
            driver.Close();
        }
    }       
}