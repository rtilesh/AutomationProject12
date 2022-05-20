using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using AutomationProject12.Base;
using AutomationProject12.Pages;

namespace AutomationProject12
{
    [Binding]
    [Scope(Tag = "BBCPageLoad")]
    public class BBCPageLoadStepDefinitions : SetUp
    {
        public IWebDriver Browser;
        BBCPageLoad bbcpageload;
        
        [Given(@"I Navigate To BBC")]
        public void GivenINavigateToBBC()
        {
            Browser = driver;
            bbcpageload = new BBCPageLoad(Browser);
            bbcpageload.NavigateToBBC();
        }

        [Then(@"I Am Able To View The Page")]
        public void ThenIAmAbleToViewThePage()
        {
            bbcpageload.CheckURL();
        }
    }
}
