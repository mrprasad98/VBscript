using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingProject.TestScript.KeyBoardActions
{
    [TestClass]
    public class TestKeyBoardActions
    {
        [TestMethod]
        public void OpenTab()
        {
            NavigationHelper.NavigateToUrl("https://www.google.com/");
          IWebElement textbox=  GenericHelper.GetElement(By.XPath("//input[@title='Search']"));
            Actions act = new Actions(ObjectRepository.Driver);
            act.SendKeys(textbox, "Hello").Perform();
        }
    }
}
