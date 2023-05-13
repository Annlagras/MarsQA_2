using MarsQA_2.Pages;
using MarsQA_2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_2.TestClass
{
    [TestFixture]
    [Parallelizable]


    public class Login : CommonDriver

    {
        [Test, Order(1), Description("Login to seller profile")]

        public void Login_Page()
        {
            // seller login to seller login page
            Seller_Login seller_Login = new Seller_Login();
            seller_Login.Seller_Login_Page();


            // seller Profile page

            Seller_Login profile_page = new Seller_Login();
            profile_page.Profile_Page();

        }



        [Test, Order(2), Description("seller add language successfully")]

        public void Language_add()
        {
            // seller add lang
            Add_Lang add_Lang = new Add_Lang();
            add_Lang.Seller_Add_Lang();

        }

        [Test, Order(3), Description("Seller delete language successfully")]

        public void Language_Delete()
        {
            Delete_Lang delete_Lang = new Delete_Lang();
            delete_Lang.Seller_Delete_Lang();

        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit(); 
        }


    }
}



