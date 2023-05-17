using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_2.Pages
{
    public class Skills
    {

        public void SkillsPage(IWebDriver driver)
        {
            //click on skills botton and add details
            IWebElement SkillsBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            SkillsBotton.Click();

            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();

            IWebElement AddSkills = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkills.SendKeys("Programming");

            IWebElement ChooseSkillLevelBotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseSkillLevelBotton.Click();

            IWebElement ExpertBotton = driver.FindElement(By.XPath("//option[@value='Expert']"));
            ExpertBotton.Click();

            IWebElement Addskillbotton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addskillbotton.Click();
            Thread.Sleep(1000);

            IWebElement AddNew1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew1.Click();
            Thread.Sleep(1000);

            IWebElement AddSkills1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
            AddSkills1.SendKeys("Web development");

            IWebElement ChooseSkillLevelBotton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
            ChooseSkillLevelBotton1.Click();

            IWebElement IntermediateBotton = driver.FindElement(By.XPath("//option[@value='Intermediate']"));
            IntermediateBotton.Click();

            IWebElement Addskillbotton1 = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            Addskillbotton1.Click();
        }

    }
}
