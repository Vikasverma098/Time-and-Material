using NUnit.Framework;

namespace June2022.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on create new
            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewbutton.Click();
            Thread.Sleep(1500);

            // Input code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Verma");

            // Input Description

            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("harry");
            Thread.Sleep(1000);

            // making price tag interactable
            IWebElement pricetag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricetag.Click();


            // Input price 

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("15");
            Thread.Sleep(1000);

            // Click on save button
            IWebElement savebutton = driver.FindElement(By.Id("SaveButton"));
            savebutton.Click();


            // Click to load last page 
            Thread.Sleep(5000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(3000);

            // Check if material record created sucessfully

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            //Assertion number 01
            Assert.That(newCode.Text == "Verma", "Actual code and Expected code do not match.");

            // Assertion number 2

            // if (newCode.Text == "Verma")
            // {
            //     Assert.Pass("New material record created successfully.");
            // }
            // else
            // {
            //     Assert.Fail("New materil record hasn't been created");
            // }
        }



        public void EditTM(IWebDriver driver)

        {
         //////////////////------->>>>>>>>> Edit Material record---------->>>>>>>>>>>>>>
            
            
            // Click to load last page 
            Thread.Sleep(5000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(3000);


            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findCodeRecordCreated.Text == "Verma")
            {
                // To edit last row(which you have just created)
                IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editbutton.Click();
                Thread.Sleep(2000);

            } 
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");

            }

            // Click and select Time from dropdown in type code
            IWebElement timeoption = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            timeoption.Click();
            Thread.Sleep(1500);

            // select between time and material type code
            IWebElement timetextbox = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            timetextbox.Click();
            Thread.Sleep(1000);


            // Clear old values and input new "Input code"
            IWebElement code1Textbox = driver.FindElement(By.Id("Code"));
            code1Textbox.Clear();
            Thread.Sleep(3000);
            code1Textbox.SendKeys("Vikas Verma");

            // Input Description

            IWebElement description1Textbox = driver.FindElement(By.Id("Description"));
            description1Textbox.Clear();
            Thread.Sleep(3000);
            description1Textbox.SendKeys("Harry Potter");


            // making price tag interactable
            IWebElement pricetag1 = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricetag1.Click();
            Thread.Sleep(2000);

            // Input price 

            IWebElement priceTextbox1 = driver.FindElement(By.Id("Price"));
            priceTextbox1.Clear();
            pricetag1.Click();
            priceTextbox1.SendKeys("1500");
            Thread.Sleep(2000);

            // Click on save button
            IWebElement savebutton1 = driver.FindElement(By.Id("SaveButton"));
            savebutton1.Click();


            // Click to load last page 
            Thread.Sleep(3000);
            IWebElement Gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Gotolastpage.Click();
            Thread.Sleep(3000);


            // Check if material record is edited and replaced by time record sucessfully

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(editedCode.Text == "Vikas Verma", "Actual code and Expected code do Not match");
            Assert.That(editedTypeCode.Text == "T", "Actual code and Expected code do Not match");
            Assert.That(editedDescription.Text == "Harry Potter", "Actual code and Expected code do Not match");
            Assert.That(editedPrice.Text == "$1,500.00", "Actual code and Expected code do Not match");


        }
        // ----------->>>>>>>>>> To Delete time & material record 
        public void DeleteTM(IWebDriver driver)
        {


            // Click to load last page 
            Thread.Sleep(5000);
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(3000);

            IWebElement findCodeRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findCodeRecordCreated.Text == "Vikas Verma")
            {
                // To delete last row(which you have just Edited)
                IWebElement Deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                Thread.Sleep(2000);
                Deletebutton.Click();
                Thread.Sleep(3000);
                driver.SwitchTo().Alert().Accept();

            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted");

            }


            Thread.Sleep(2000);
            IWebElement deletedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement deletedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement deletedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement deletedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(deletedCode.Text != "Vikas Verma", "Code record hasn't been deleted");
            Assert.That(deletedTypeCode.Text != "T", "Typecode record hasn't been deleted");
            Assert.That(deletedDescription.Text != "Harry Potter", "Description record hasn't been deleted");
            Assert.That(deletedPrice.Text != "$1,500.00", "Price record hasn't been deleted");

        }



    }
}
