using System;
using TechTalk.SpecFlow;
using Nextlogin.Base;
using Nextlogin.Page;
using OpenQA.Selenium;

namespace Nextlogin.Step
{
    [Binding]
    [Scope(Tag = "regreesion")]
    public class NextloginSteps:Nexthooks
    {
        public IWebDriver Browser;
        public NextPage signin;
        [Given(@"I navigate to Next website")]
        public void GivenINavigateToNextWebsite()
        {
            Browser = Driver;
            signin = new NextPage(Browser);
            signin.NavigateMethod();
        }
        
        [When(@"I click on My Account")]
        public void WhenIClickOnMyAccount()
        {
            signin.clickMyAccount();
   ;        }
        
        [When(@"I enter user details")]
        public void WhenIEnterUserDetails()
        {
            signin.userdetails();
        }
        
        [Then(@"I am able to sign in")]
        public void ThenIAmAbleToSignIn()
        {
            signin.VerifyPageload();
        }
    }
}
