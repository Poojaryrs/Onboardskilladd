using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboardskilladd.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // Launch mars portal and navigate to login page
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Profile");

            // identify username field and enter valid username by right click on field and click inspect, go to elements tab and select the identifier i.e. id
            IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div/div[1]/input"));
            usernameTextbox.SendKeys("poojarahulsingh.2023@gmail.com");

            // identify password field and enter valid password by right click on field and click inspect, go to elements tab and select the identifier i.e. id
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("MVPstudio@2023");

            // identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(5000);
        }
    }
}
