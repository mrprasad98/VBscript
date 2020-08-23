using BankingProject.BaseClasses;
using BankingProject.ComponentHelper;
using BankingProject.Settings;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.PageObject
{
    public class LoginPage : PageBase
    {
        private IWebDriver driver;
        #region WebElements

        // [FindsBy(How = How.Id, Using = "Bugzilla_login")]
        private IWebElement LoginTextBox => driver.FindElement(By.Id("Bugzilla_login"));

        //[FindsBy(How = How.Id, Using = "Bugzilla_password")]
        private IWebElement PasswordTextBox => driver.FindElement(By.Id("Bugzilla_password"));

        //[FindsBy(How = How.Id, Using = "log_in")]
        private IWebElement LoginButton => driver.FindElement(By.Id("log_in"));

        //[FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement HomeLink => driver.FindElement(By.LinkText("Home"));

        
        #endregion
        public LoginPage(IWebDriver _driver):base(_driver)
            {
            this.driver = _driver;
            }
        #region Actions
        public EnterBugPage Login(string username, String password)
        {
            LoginTextBox.SendKeys(username);
            PasswordTextBox.SendKeys(password);
            LoginButton.Click();
            return new EnterBugPage(driver);
            
        }
        #endregion

        #region Navigation
        public void NavigateToHome()
        {
            HomeLink.Click();
        }
        #endregion
    }
}
