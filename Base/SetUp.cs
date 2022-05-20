using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject12.Base
{
    public class SetUp
    {
        public IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //NOTE: Since, url is not changing with our each test,
            //we have below GoToUrl line here instead of seperate
            //Navigation method in Step file. If we do this way then
            //we can remove Given line from each step:
            //driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Close();
            driver.Quit();
        }
    }
}