using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onboardskilladd.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {

            // navigate to T&M module
            Thread.Sleep(5000);
            IWebElement skillpage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillpage.Click();

        }
    }
}
