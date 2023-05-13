using MarsQA_2.Pages;
using MarsQA_2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Xml.Linq;
using TechTalk.SpecFlow;
using static System.Collections.Specialized.BitVector32;

namespace MarsQA_2.StepDefinitions
{
    [Binding]
    public class SellerLoginAndUpdateLanguageStepDefinitions:CommonDriver
    {

        IWebDriver driver = new ChromeDriver();


        [Given(@"the seller is on the login page")]
        public void GivenTheSellerIsOnTheLoginPage()
        {
            Seller_Login home = new Seller_Login();
            home.Go_To_Home();

        }
        [When(@"the seller enter the username and password successfully")]
        public void WhenTheSellerEnterTheUsernameAndPasswordSuccessfully()
        {


            Seller_Login seller_Login = new Seller_Login();
            seller_Login.Seller_Login_Page();

        }

        [Then(@"the seller able to see the seller's profile page")]
        public void ThenTheSellerAbleToSeeTheSellersProfilePage()
        {
           // IWebElement profileName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
          //  if (profileName.Text == "Hi Anna")

            //{
               // Console.WriteLine("Succesfully Login, Test PASSED");

          //  }

            //else
          //  {
            //    Console.WriteLine("Login Failed,Test FAIL");
           // }            //Assert.IsNotNull(profileName);
        }



        [Given(@"the seller is on the profile page")]
        public void GivenTheSellerIsOnTheProfilePage()
        {
          
            // seller Profile page

            Seller_Login profile_page = new Seller_Login();
            profile_page.Profile_Page();


        }

        [When(@"the seller add new language")]
        public void WhenTheSellerAddNewLanguage()
        {
            // seller add lang
            Add_Lang add_Lang = new Add_Lang();
            add_Lang.Seller_Add_Lang();
        }

        [Then(@"the new language should be saved")]
        public void ThenTheNewLanguageShouldBeSaved()
        {
         //   throw new PendingStepException();
        }

        [When(@"the seller delete the language")]
        public void WhenTheSellerDeleteTheLanguage()
        {

            Delete_Lang delete_Lang = new Delete_Lang();
            delete_Lang.Seller_Delete_Lang();
        }

        [Then(@"the deleted language should be removed")]
        public void ThenTheDeletedLanguageShouldBeRemoved()
        {
            //throw new PendingStepException();
        }
    }
}
