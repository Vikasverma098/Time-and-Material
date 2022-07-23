using June2022.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June2022.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Tests : CommanDriver
    {

        // Page Object Initilisation.--------------------------->>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test, Order(1)]
        public void CreateEmployee()
        {          
            homePageObj.GoToEmployeePage(driver);            
            employeePageObj.CreateEmployee(driver);
        }

        [Test, Order(2)]
        public void EditEmployee()
        {            
            homePageObj.GoToEmployeePage(driver);            
            employeePageObj.EditEmployee(driver, "iuj", "uiy");
        }

        [Test, Order(3)]

        public void DeleteEmployee()
        {
        
            homePageObj.GoToEmployeePage(driver);            
            employeePageObj.DeleteEmployee(driver);
        }

        
    }
}
