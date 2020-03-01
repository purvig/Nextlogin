using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Nextlogin.Base
{
    
    public  class Nexthooks
    {
        public IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Cookies.DeleteAllCookies();
;        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
            Driver.Quit();

        }
    }
}
