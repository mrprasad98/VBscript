using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.BaseClasses
{
    public class PageBase
    {
        private IWebDriver driver;
        #region WebElements

        //[FindsBy(How =How.LinkText, Using = "Home")]
        private IWebElement HomeLink => driver.FindElement(By.LinkText("Home"));

        //[FindsBy(How =How.LinkText, Using = "Log out")]
        private IWebElement LogoutLink => driver.FindElement(By.LinkText("Log out"));

        //[FindsBy(How =How.LinkText, Using = "Browse")]
        private IWebElement BrowseLink => driver.FindElement(By.LinkText("Browse"));

        //[FindsBy(How =How.LinkText, Using = "New")]
        private IWebElement NewLink => driver.FindElement(By.LinkText("New"));

        //[FindsBy(How = How.Id, Using = "login_link_top")]
        private IWebElement LoginLink => driver.FindElement(By.Id("login_link_top"));
        #endregion
        public PageBase(IWebDriver _driver)
        {
            //  PageFactory.InitElements(_driver, this);
            this.driver = _driver;
        }
        #region Actions
        protected void Logout()
        {
            LogoutLink.Click();
        }
        protected void NavigateToBrowser()
        {
            BrowseLink.Click();
        }
        protected void NavigateToNew()
        {
            NewLink.Click();
        }
        public string Title
        {
           get { return driver.Title; }
        }
        public void ClickOnLoginLink()
        {
            LoginLink.Click();
        }
        #endregion
        #region Navigation
        protected void NavigateToHomePage()
        {
            HomeLink.Click();
        }
        
        #endregion
    }
}
