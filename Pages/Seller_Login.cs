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
    public class Seller_Login
    {


        public void Seller_Login_Page(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            //launch local host
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //login to local host
            IWebElement SigninTextbox = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            SigninTextbox.Click();
            IWebElement EmailId = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            EmailId.SendKeys("annajoyedassery92@gmail.com");
            IWebElement Password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            Password.SendKeys("Annajoy@1992");
            IWebElement SigninButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            SigninButton.Click();
            Thread.Sleep(1000);
            //click profile botton
            IWebElement Profilebotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            Profilebotton.Click();



        }
    }
}
