using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsQA_2.Utilities;
namespace MarsQA_2.Pages
{
    public class Seller_Login:CommonDriver
    {
    IWebDriver driver = new ChromeDriver();


        public void Go_To_Home()
        {
            driver.Manage().Window.Maximize();
            // launch turnup portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            Thread.Sleep(1500);

        }

        public void Seller_Login_Page()
        {
            IWebElement loginButton1 = driver.FindElement(By.XPath("/*[@id='home']/div/div/div[1]/div/a"));
            loginButton1.Click();

            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("annajoyedassery92@gmail.com");

            //  Assert.Fail("TurnUp portal page did not launch");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Annajoy@1992");

            // click login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
        }

        public void Profile_Page()

        {
            IWebElement profileName1 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/div[1]/div[2]/div/span"));
            profileName1.Click();

            IWebElement gotoProfile = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/div[1]/div[2]/div/span/div/a[1]"));
            gotoProfile.Click();
            //Assert.IsNotNull(profileName);
        }




    }
}
