using BankingProject.BaseClasses;
using BankingProject.ComponentHelper;
using BankingProject.PageObject;
using BankingProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BankingProject.StepDefination
{
    [Binding]
    public sealed class LandingFeatureStep
    {
        HomePage hpage;
        LoginPage lpage;
        EnterBugPage epage;
        [Given(@"User should use Buzgilla URL")]
        public void GivenUserShouldUseBuzgillaURL()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
        }
        [When(@"User clicked on Enter Bug link")]
        public void WhenUserClickedOnEnterBugLink()
        {
            hpage = new HomePage(ObjectRepository.Driver);
           lpage= hpage.NavigateToLoginPage();
            epage=lpage.Login(ObjectRepository.config.GetUsername(), ObjectRepository.config.GetPassword());
           // epage.ClickLogout();
            
        }
        [Then(@"User should be at Enter Bug Page")]
        public void ThenUserShouldBeAtEnterBugPage()
        {
            AssertHelper.AssertEqual("Enter Bug: TestProduct", epage.Title);
        }
        [When(@"User provides data as Severity, Hardware, OS, Summary and Description")]
        public void SelectFromCombo()
        {

            epage.SelectCombo("major", "Other", "Linux");
            //epage.TypeIn("rajendra prasad", "Bug entered");
            epage.SubmitButton();
            
        }



    }
}
