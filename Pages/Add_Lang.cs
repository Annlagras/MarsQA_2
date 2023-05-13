using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace MarsQA_2.Pages
{
    public class Add_Lang
    {
        IWebDriver driver = new ChromeDriver();

        public void Seller_Add_Lang()
        {
            IWebElement tabButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            tabButton.Click();

            //click ADD NEW
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();


            // Enter the value in textbox language
            IWebElement valueTextbox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            valueTextbox.SendKeys("Marathi");


            // dropdown box option select
            IWebElement levelButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            levelButton.Click();
            SelectElement select = new SelectElement(levelButton);
            select.SelectByValue("Basic");



            //submit add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }




    }
}
