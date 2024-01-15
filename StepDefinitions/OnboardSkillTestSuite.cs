using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Onboardskilladd.Pages;
using Onboardskilladd.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Onboardskilladd.StepDefinitions
{
    [Binding]
    public class OnboardSkillTestSuite : CommonDriver
    {
        [Given(@"User logs into the portal")]
        public void GivenUserLogsIntoThePortal()
        {
            // Open Chrome Browser
            driver = new ChromeDriver();
            Thread.Sleep(1000);

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);

            //throw new PendingStepException();
        }

        [Given(@"user navigates to skill page")]
        public void GivenUserNavigatesToSkillPage()
        {
            //homepage object inititalization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
            //throw new PendingStepException();
        }

        [When(@"user creates a new skill")]
        public void WhenUserCreatesANewSkill()
        {
            //TMPage object inititalization and definition
            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateSkillRecord(driver);//throw new PendingStepException();
        }

        [Then(@"portal should save the skill")]
        public void ThenPortalShouldSaveTheSkill()
        {
            TMPage tmPageObj = new TMPage();
            tmPageObj.AssertCreateTMRecord(driver);
            //throw new PendingStepException();
        }
    }
}
