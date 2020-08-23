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
    public class EnterBugPage: PageBase
    {
        private IWebDriver driver;

        #region WebElements

        // [FindsBy(How =How.Id, Using = "bug_severity")]
        private IWebElement SeverityDropdown => driver.FindElement(By.Id("bug_severity"));

        //[FindsBy(How =How.Id, Using = "rep_platform")]
        private IWebElement HardwareDropdown => driver.FindElement(By.Id("rep_platform"));

        //[FindsBy(How =How.Id, Using = "op_sys")]
        private IWebElement OSDropdown => driver.FindElement(By.Id("op_sys"));

        //[FindsBy(How = How.Id, Using = "short_desc")]
        private IWebElement SummaryTextBox => driver.FindElement(By.Id("short_desc"));

        //[FindsBy(How = How.Id, Using = "commit")]
        private IWebElement SubmitBugButton => driver.FindElement(By.Id("commit"));


        //[FindsBy(How =How.Id, Using = "comment")]
        private IWebElement DescriptionDropdown => driver.FindElement(By.Id("comment"));

        //[FindsBy(How =How.Id,Using = "commit_top")]
        private IWebElement SaveChanges => driver.FindElement(By.Id("commit_top"));
        #endregion

        #region Action
        
        public void ClickLogout()
        {
            Logout();
        }
        public  bool IsElementPresent()
        {
            return SaveChanges.Displayed;
        }
        public EnterBugPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
        public void SelectFrom(String value)
        {
            ComboBoxHelper.SelectElement(SeverityDropdown, value);
            
                    }
        public void Summary(string text)
        {
            TextBoxHelper.TypeInTextBox(SummaryTextBox, text);
        }
        public void SelectOS(int index)
        {
            ComboBoxHelper.SelectIndex(OSDropdown, 2);
            
        }
        public void  SelectHardware(String value)
        {
            ComboBoxHelper.SelectElement(HardwareDropdown, value);
            
            
        }
        public void SubmitButton()
        {
            SubmitBugButton.Click();
        }
        public void SelectCombo(String Severity1, String Hardware, String OS)
        {
            if (SeverityDropdown != null)
                ComboBoxHelper.SelectElement(SeverityDropdown, Severity1);
            if (Hardware != null)
                ComboBoxHelper.SelectElement(HardwareDropdown, Hardware);
            if (OS != null)
                ComboBoxHelper.SelectElement(OSDropdown, OS);
        }
        public void TypeIn(string Summary=null, string Description=null )
        {
            if (Summary != null)
                TextBoxHelper.TypeInTextBox(SummaryTextBox, Summary);
            if (Description != null)
                TextBoxHelper.TypeInTextBox(DescriptionDropdown, Description);
        }
        #endregion
    }
}