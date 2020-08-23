using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            ObjectRepository.Driver.FindElement(By.LinkText("Quick Search help"));
            ObjectRepository.Driver.FindElement(By.Id("enter_bug"));

        }

    }
}
