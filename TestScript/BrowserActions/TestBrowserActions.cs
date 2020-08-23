using BankingProject.ComponentHelper;
using BankingProject.ComponentHelper.BrowserHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            LinkHelper.ClickOnLink(By.LinkText("Quick Search help"));
            BrowserActionsHelper.GoForward();
            BrowserActionsHelper.Refresh();
            BrowserActionsHelper.GoBack(); 
        }
    }
}
