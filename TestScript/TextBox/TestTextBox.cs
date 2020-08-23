using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
                        LinkHelper.ClickOnLink(By.LinkText("File a Bug"));
            //IWebElement element=ObjectRepository.Driver.FindElement(By.Id("Bugzilla_login"));
            //element.SendKeys(ObjectRepository.config.GetUsername());
            //element.SendKeys(ObjectRepository.config.GetPassword());
            //element.Clear();
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.config.GetPassword());
            TextBoxHelper.ClearTextBox(By.Id("Bugzilla_login"));

        }
    }
}
