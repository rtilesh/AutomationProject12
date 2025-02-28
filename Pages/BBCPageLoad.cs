﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;

namespace AutomationProject12.Pages
{
    class BBCPageLoad
    {
        public IWebDriver Driver;
        public string url = "https://www.bbc.com";

        public BBCPageLoad(IWebDriver browser)
        {
            Driver = browser;
            PageFactory.InitElements(Driver, this);
        }

        public void NavigateToBBC()
        {
            Driver.Navigate().GoToUrl("https://bbc.co.uk");
        }

        public void CheckURL()
        {
            Driver.Url.Contains(url).Should().BeTrue();
        }

    }
}
