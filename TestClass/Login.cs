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




  IWebDriver driver = new ChromeDriver();


// Login page object Initialization and definition

Seller_Login login = new Seller_Login();
login.Seller_Login_Page(driver);

// LanguagePage object Initialization and definition

Add_Lang loginPageObj = new Add_Lang();
loginPageObj.Seller_Add_Lang(driver);

// EducationPage Object Initialization and definition

EducationPage EducationPageobj = new EducationPage();
EducationPageobj.Education(driver);

// Certification page object Intialization and definition

CertificatePage CertificationPageObj = new CertificatePage();
CertificationPageObj.Certification(driver);

//Languge delete 

Delete_Lang deleteObj = new Delete_Lang();
deleteObj.Seller_Delete_Lang(driver);





