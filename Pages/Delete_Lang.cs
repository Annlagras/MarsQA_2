using MarsQA_2.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_2.Pages
{
    public class Delete_Lang
    {

        public void Seller_Delete_Lang(IWebDriver driver)
        {//click on Language button and add details
            IWebElement Languagebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
            Languagebutton.Click();

           IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
          deletebutton.Click();

            Thread.Sleep(1000);

            
        }

    }
}
