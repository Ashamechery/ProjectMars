using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProjectMars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open the chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //launch turnup  portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //click on signin
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinButton.Click();
            //Identify user name text box and enter valid user name
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("ashamechery11@gmail.com");

            //identify password and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Keziahshaji@123#");
            //click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(5000);
            //check if i successfully loggedin
            IWebElement helloAsha = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Thread.Sleep(5000);
            if (helloAsha.Text == "Hi Asha")
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("failed");
            }
            //adding languages
            //select language section
            IWebElement Language = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            //clink on add new for adding languages
            IWebElement addNew = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();
            // type the language
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.SendKeys("malayalam");
            //choose the llevel for language
            IWebElement chooseLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            chooseLevel.Click();
            //choose basic level
            IWebElement basicLevelAdd = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            basicLevelAdd.Click();
            IWebElement add = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add.Click();
            Thread.Sleep(2000);

            //Edting created element
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
            editButton.Click();
            //updating created language
            IWebElement addLangupdate= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            addLangupdate.Clear();
            addLangupdate.SendKeys("Hindi");
            //click the level for updating language
             IWebElement chooseLevelupdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
             chooseLevelupdate.Click();
            //click on update fluent level 
            IWebElement fluentUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            fluentUpdate.Click();
            Thread.Sleep(2000);
            //Delete created lang
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteButton.Click();


        }
    }
}
