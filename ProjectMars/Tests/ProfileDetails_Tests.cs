using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectMars.Pages
{
    internal class ProfileDetails_Tests
    {
        static void Main(string[] args)
        {
            //open the chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();  
            loginPageObj.LoginSteps(driver);

            //Profile page object initialization and definition
            ProfilePage profilePageObj=new ProfilePage();
            profilePageObj.CreateProfileDetails(driver);
            //edit
            profilePageObj.EditProfileDetails(driver);
            //delete
            profilePageObj.DeleteProfileDetails(driver);
        }
    }
}
