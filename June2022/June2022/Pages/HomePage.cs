using NUnit.Framework;

namespace June2022.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            try
            {
                // Click on administration tab
                Thread.Sleep(1500);
                IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationtab.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");
            }
            catch(Exception ex)
            {
                Assert.Fail("TM option not available", ex.Message);
            }


            // Select time and material from drop down list
            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
            

        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            try
            {
                // Click on administration tab
                Thread.Sleep(1500);
                IWebElement administrationtab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
                administrationtab.Click();
                WaitHelpers.WaitToBeClickable(driver, 5, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");
            }
            catch (Exception ex)
            {
                Assert.Fail("Employee page not available", ex.Message);
            }


            // Select employee tab from drop down list
            IWebElement employeePageObj = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeePageObj.Click();


        }
    }
}
