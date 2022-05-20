using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace AutomationProject12.Pages
{
    public class BBCSignIn
    {
        public IWebDriver Driver;

        public BBCSignIn(IWebDriver brawser)
        {
            Driver = brawser;
            PageFactory.InitElements(Driver, this);
        }

        //string ExpectedMessage = "Welcome to the BBC";   <--works on bbc.co.uk
        string ExpectedMessage = "Welcome to BBC.com";

        //[FindsBy(How = How.LinkText, Using = "Sign in")]   <--works on bbc.co.uk
        [FindsBy(How = How.Id, Using = "idcta-username")]
        //[FindsBy(How = How.CssSelector, Using = "#idcta-username")]   <--also works
        public IWebElement SigninLink;

        //[FindsBy(How = How.Id, Using = "user-identifier-input")]   <--works on bbc.co.uk
        [FindsBy(How = How.Id, Using = "user-identifier-input")] //"username-label")] --Gives error
        public IWebElement Username;

        [FindsBy(How = How.Id, Using = "password-input")] //"password-label")] --Givew error
        public IWebElement Password;

        [FindsBy(How = How.Id, Using = "submit-button")]
        public IWebElement SignInButton;

        //[FindsBy(How = How.CssSelector, Using = "#header-content>div:nth-child(3)>div>div>div>div>div")]   <--works on bbc.co.uk
        //[FindsBy(How = How.CssSelector, Using = "#page > section.module.module--header > h2 > span")]   <--works with spaces also
        [FindsBy(How = How.CssSelector, Using = "#page>section.module.module--header>h2>span")]
        public IWebElement WelcomeMessage;

        public void NavigateToBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.com");
        }

        public void ClickSigninLink()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            SigninLink.Click();
        }

        public void UserDetails()
        {
            //Username.SendKeys("sheetal_jn@hotmail.com");
            //Password.SendKeys("Sheetal123@");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Username.SendKeys("rtilesh@hotmail.com");
            Password.SendKeys("Tilesh123");
        }

        public void ClickSignButton()
        {
            SignInButton.Click();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public void VerifyLogin()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            WelcomeMessage.Text.Contains(ExpectedMessage).Should().BeTrue();
        }

    }
}
