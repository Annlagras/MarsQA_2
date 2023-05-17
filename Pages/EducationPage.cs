using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_2.Pages
{
    public class EducationPage
    {

        public void Education(IWebDriver driver)
        {
            //click on Education botton and add details

            IWebElement Education = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            Education.Click();

            IWebElement AddNewEducation = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            AddNewEducation.Click();

            IWebElement CollegeName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            CollegeName.SendKeys("MG University");

            IWebElement SelectCountry = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            SelectCountry.Click();

            IWebElement Country = driver.FindElement(By.XPath("//option[@value='India']"));
            Country.Click();

            IWebElement TitleButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            TitleButton.Click();

            IWebElement SelectTitle = driver.FindElement(By.XPath("//option[@value='M.Tech']"));
            SelectTitle.Click();

            IWebElement Degree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            Degree.SendKeys("Master's in Computer Applications");

            IWebElement YearofDegree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            YearofDegree.Click();

            IWebElement Selectyear = driver.FindElement(By.XPath("//option[@value='2016']"));
            Selectyear.Click();

            IWebElement AddEducationButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddEducationButton.Click();
        }




    }
}
