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
        IWebDriver driver = new ChromeDriver();

        public void Seller_Delete_Lang()
        {
            IWebElement tabButton1 = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            tabButton1.Click();

            IWebElement removeButon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[2]/tr/td[3]/span[2]/i"));
            removeButon.Click();
        }

    }
}
