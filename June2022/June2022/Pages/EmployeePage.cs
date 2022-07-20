using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Pages
{
     public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            // Click on create
            IWebElement createbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbutton.Click();
            Thread.Sleep(1500);

            // Input Name
            IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            nameTextbox.SendKeys("HANNA");

            // Input Username

            IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            usernameTextbox.SendKeys("HANNA HARRY");
            Thread.Sleep(1000);

            // Input Contact

            IWebElement contactTextbox = driver.FindElement(By.Id("ContactDisplay"));
            contactTextbox.SendKeys("Ksenia Drive, Auckland");
            Thread.Sleep(1000);

            // Input Password

            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("Verma@098");
            Thread.Sleep(1000);

            // ReInput Password

            IWebElement retypePasswordTextbox = driver.FindElement(By.Id("RetypePassword"));
            retypePasswordTextbox.SendKeys("Verma@098");
            Thread.Sleep(1000);

            // Input Vehicle details
            IWebElement vehicleTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            vehicleTextbox.SendKeys("Toyota");
            Thread.Sleep(1500);

            // Click on groups to make interactable
            IWebElement groupTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            groupTextbox.Click();
            Thread.Sleep(1500);

            // Select required group you want
            IWebElement groupIndex = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[13]"));
            groupIndex.Click();
            Thread.Sleep(1000);

            // Click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();
            Thread.Sleep(1500);

            // Click on "Back to list"
            IWebElement backToListText = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            backToListText.Click();

            // Click to load last page of employee module
            Thread.Sleep(5000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(3000);

            // Check if Employee record created sucessfully

            IWebElement newName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //Assertion number 01
            Assert.That(newName.Text == "HANNA", "Actual code and Expected code do not match.");


        }


        public void EditEmployee(IWebDriver driver)
        {

            //////////////////------->>>>>>>>> Edit Employee record---------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            // Click to load last page of employee module
            Thread.Sleep(3000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(3000);


            IWebElement findnameRecordCreated = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findnameRecordCreated.Text == "HANNA")
           
            {
                // To edit last row(which you have just created)
                IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                editbutton.Click();                                    
                Thread.Sleep(2000);                                   

            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");

            }

            // Input  editName
            IWebElement editNameTextbox = driver.FindElement(By.Id("Name"));
            editNameTextbox.Clear();
            editNameTextbox.SendKeys("A1B2C3");

            // Input editUsername

            IWebElement editUsernameTextbox = driver.FindElement(By.Id("Username"));
            editUsernameTextbox.Clear();
            editUsernameTextbox.SendKeys("ABC123");
            Thread.Sleep(1000);

            // Click on groups to make interactable
            IWebElement editGroupTextbox = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            editGroupTextbox.Click();
            Thread.Sleep(1500);

            // Select required group you want
            IWebElement editGroupIndex = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[10]"));
            editGroupIndex.Click();
            Thread.Sleep(1000);

            // Click on save button
            IWebElement editSavebutton = driver.FindElement(By.Id("SaveButton"));
            editSavebutton.Click();
            Thread.Sleep(1500);

            // Click on "Back to list"
            IWebElement editBackToListText = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            editBackToListText.Click();

            // Click to load last page of employee module
            Thread.Sleep(5000);
            IWebElement editGotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            editGotolastpage.Click();
            Thread.Sleep(2000);

            // Check if employee record is edited and save sucessfully

            IWebElement editedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            

            Assert.That(editedName.Text == "A1B2C3", "Actual name and Expected name do Not match");
            Assert.That(editedUserName.Text == "ABC123", "Actual username and Expected username do Not match");

        }


        public void DeleteEmployee(IWebDriver driver)
        {
            // Click to load last page of employee module
            Thread.Sleep(5000);
            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Gotolastpage.Click();
            Thread.Sleep(2000);

            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findCodeRecordCreated.Text == "A1B2C3")
            {
                // To delete last row(which you have just Edited)
                IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
                Thread.Sleep(2000);                                      
                Deletebutton.Click();
                Thread.Sleep(3000);
                driver.SwitchTo().Alert().Accept();

            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");

            }


            Thread.Sleep(3000);
            IWebElement deletedName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement deletedUserName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            

            Assert.That(deletedName.Text != "A1B2C3", "Name record hasn't been deleted");
            Assert.That(deletedUserName.Text != "ABC123", "Username record hasn't been deleted");
            
        }
    }
}
