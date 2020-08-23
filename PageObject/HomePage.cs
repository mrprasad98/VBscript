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
    public class HomePage : PageBase
    {
        private IWebDriver driver;
        #region WebElements

        // [FindsBy(How =How.Id,Using = "quicksearch_main")]
        private IWebElement QuickSearchTextBox => driver.FindElement(By.Id("quicksearch_main"));

        //[FindsBy(How =How.Id, Using = "find")]
        private IWebElement QuickSearchButton => driver.FindElement(By.Id("find"));


        // [FindsBy(How =How.LinkText,Using = "File a Bug")]
        private IWebElement FileABugLink => driver.FindElement(By.LinkText("File a Bug"));


        #endregion
        public HomePage(IWebDriver _driver):base(_driver)
        {
            this.driver = _driver;
        }


        #region Actions
        public void QuickSearch(String text)
        { 
            QuickSearchTextBox.SendKeys(text);
            QuickSearchButton.Click();
            
        }
        #endregion

        #region Navigation
        public LoginPage NavigateToLoginPage()
        {
            FileABugLink.Click();
            
            
            return new LoginPage(driver);
        }
        #endregion
    }
}
