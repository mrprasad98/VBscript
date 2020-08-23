using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.HyperLink
{
    [TestClass]
    public class TestHyperLink
    {
        [TestMethod]
        public void ClickLink()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            //IWebElement element=ObjectRepository.Driver.FindElement(By.LinkText("File a Bug"));
            //element.Click();

            LinkHelper.ClickOnLink(By.LinkText("File a Bug"));

            
        }
    }
}
    