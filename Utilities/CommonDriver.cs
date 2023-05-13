using MarsQA_2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_2.Utilities
{
    public class CommonDriver
    {

        public static IWebDriver driver;
        [SetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            // Login page object initialization and definition
           Seller_Login loginPageObj = new Seller_Login();
           loginPageObj.Go_To_Home();
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }











    }
}
