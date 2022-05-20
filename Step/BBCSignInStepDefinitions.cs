using System;
using TechTalk.SpecFlow;
using AutomationProject12.Pages;
using AutomationProject12.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject12
{
    [Binding]
    [Scope(Tag = "BBCSignIn")]
    public class BBCSignInStepDefinitions : SetUp
    {
        public IWebDriver Browser;
        public BBCSignIn signin;
        // public BBCPageLoad page;


        [Given(@"I navigate to BBC Website")]
        public void GivenINavigateToBBCWebsite()
        {

            Browser = driver;
            //  page = new BBCPageLoad(Browser);
            //page.NavigateToBBC();
            signin = new BBCSignIn(Browser);
            signin.NavigateToBBC();

        }

        [When(@"I click on Account link")]
        public void WhenIClickOnAccountLink()
        {

            signin.ClickSigninLink();
        }

        [When(@"I enter my username and password")]
        public void WhenIEnterMyUsernameAndPassword()
        {
            signin.UserDetails();
        }

        [When(@"I click signin")]
        public void WhenIClickSignin()
        {
            signin.ClickSignButton();
        }

        [Then(@"I am able to signin successfully")]
        public void ThenIAmAbleToSigninSuccessfully()
        {
            signin.VerifyLogin();
        }
    }
}