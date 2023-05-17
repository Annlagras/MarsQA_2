using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using MarsQA_2.Utilities;

namespace MarsQA_2.Pages
{
    public class Add_Lang
    {
       

        public void Seller_Add_Lang(IWebDriver driver)

        { //click on Language button and add details
            IWebElement Languagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            Languagebutton.Click();

            IWebElement Addbutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            Addbutton.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 5);

            IWebElement AddLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage.SendKeys("English");

            IWebElement ChooseLanguagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguagebutton.Click();
            Thread.Sleep(1000);

            IWebElement BasicButton = driver.FindElement(By.XPath("//option[@value='Basic']"));
            BasicButton.Click();

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(500);

            // Fluent option


            IWebElement AddButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddButton1.Click();
            Thread.Sleep(500);

            IWebElement AddLanguage1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage1.SendKeys("Malayalam");

            IWebElement ChooseLanguageButton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguageButton1.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//option[@value='Fluent']", 5);


            IWebElement FluentButton = driver.FindElement(By.XPath("//option[@value='Fluent']"));
            FluentButton.Click();

            Wait.WaitForElementTobeclicable(driver, "Xpath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]", 5);

            IWebElement AddButton2 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton2.Click();
            Thread.Sleep(1500);

        }




    }
}
