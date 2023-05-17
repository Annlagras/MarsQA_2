using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using MarsQA_2.Pages;

namespace MarsQA_2.StepDefinitions
{
    [Binding]
    public class SellerAddingProfileDetailsStepDefinitions
    {
        [Given(@"seller logged into localhost successfully")]
        public void GivenSellerLoggedIntoLocalhostSuccessfully()
        {
           IWebDriver driver = new ChromeDriver();
            Seller_Login login = new Seller_Login();
            login.Seller_Login_Page(driver);
        }

        [When(@"seller navigate to Profile Page")]
        public void WhenSellerNavigateToProfilePage()
        {
            IWebDriver driver = new ChromeDriver();
            Add_Lang loginPageObj = new Add_Lang();
            loginPageObj.Seller_Add_Lang(driver);
        }

        [When(@"seller added the profile details")]
        public void WhenSellerAddedTheProfileDetails()
        {

            IWebDriver driver = new ChromeDriver();
            // adding skills to profile
            Skills SkillsPageObj = new Skills();
            SkillsPageObj.SkillsPage(driver);

            // adding education details to profile
            EducationPage EducationPageobj = new EducationPage();
            EducationPageobj.Education(driver);

            // adding certifications to profile
            CertificatePage CertificationPageObj = new CertificatePage();
            CertificationPageObj.Certification(driver);




        }

        [Then(@"The profile details added successfully")]
        public void ThenTheProfileDetailsAddedSuccessfully()
        {


        }

        [When(@"seller updated '([^']*)' details")]
        public void WhenSellerUpdatedDetails(string language)
        {
            IWebDriver driver = new ChromeDriver();
            Add_Lang loginPageObj = new Add_Lang();
            loginPageObj.Seller_Add_Lang(driver);
        }

        [Then(@"The details added successfully '([^']*)'")]
        public void ThenTheDetailsAddedSuccessfully(string language)
        {


        }

        [When(@"seller navigate to profile page")]
        public void WhentheSellerNavigateToProfilePage()
        {

        }

        [When(@"seller select a <'([^']*)'")]
        public void WhenSellerSelectA(string language)
        {

        }

        [When(@"seller delete the selected '([^']*)' details")]
        public void WhenSellerDeleteTheSelectedDetails(string english)
        {
            IWebDriver driver = new ChromeDriver();
           Delete_Lang deleteObj = new Delete_Lang();
           deleteObj.Seller_Delete_Lang(driver);
    
          }

        [Then(@"the details removed successfully '([^']*)'")]
        public void ThenTheDetailsRemovedSuccessfully(string english)
        {

        }
    }
}
