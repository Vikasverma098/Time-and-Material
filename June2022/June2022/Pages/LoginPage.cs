﻿
namespace June2022.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl(" http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            // identify username textbox amd enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

        }
    }
}
