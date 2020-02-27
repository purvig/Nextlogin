using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using FluentAssertions;


namespace Nextlogin.Page
{
    
     public class NextPage
    {
        public IWebDriver driver;

        public NextPage(IWebDriver Browser)
        {
            driver = Browser;
            PageFactory.InitElements(driver, this);
        }
        public void NavigateMethod()
        {
            driver.Navigate().GoToUrl("https://www.next.co.uk/ ");
        }
        public void clickMyAccount()
        {
            MyAccount.Click();
        }
        [FindsBy(How = How.CssSelector, Using = "body.Homepage.font-antialiased.bp1280.bp1440.JSEnabled.webkit.chrome.chrome-8:nth-child(2) header.PageHeader.font-antialiased:nth-child(18) div.HeaderContent section.HeaderTopBar.Content section.QuickLinks ul:nth-child(1) li:nth-child(1) > a:nth-child(1)")]
        public IWebElement MyAccount;
        public void userdetails()
        {
            Username.SendKeys("pv_gangwal@yahoo.co.uk");
            Password.SendKeys("Tia1156v");
            Signin.Click();
            Task.Delay(5000).Wait();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\vgangwal\source\repos\Nextlogin\Nextlogin\SC.aa.Jpeg", ScreenshotImageFormat.Jpeg);
            Task.Delay(6000).Wait();
        }
        [FindsBy(How = How.CssSelector, Using = "#EmailOrAccountNumber")]
        public IWebElement Username;
        [FindsBy(How = How.CssSelector, Using = "#Password")]
        public IWebElement Password;
        [FindsBy(How = How.CssSelector, Using = "#SignInNow")]
        public IWebElement Signin;
        [FindsBy(How = How.CssSelector, Using = "body.Generic.MenuLeft.ctoc.bp1280.bp1440.JSEnabled.webkit:nth-child(2) div.accountsummaryCash.MainContent:nth-child(13) div:nth-child(3) div.linkSection:nth-child(6) div:nth-child(1) div.container.body-content > h1.boxclassic:nth-child(8)")]
        public IWebElement WelcomeMessage;
        
        public void VerifyPageload()
        {
            WelcomeMessage.Text.Contains("HELLO MRS P GANGWAL").Should().BeTrue();
        }
        

    }

    
} 
