using Competition_Task.Pages;
using Competition_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver(@"E:\Competition Task");

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions();
        }


        [TearDown]
        public void ClosingSteps()
        {
            driver.Quit();
        }
    }
}