using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.RadioButton
{
    [TestClass]
    public class TestRadioButton
    {[TestMethod]
        public void TestRadio()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            LinkHelper.ClickOnLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            LinkHelper.ClickOnLink(By.XPath("//div[@id='header']/ul[1]/li[9]/a"));
            LinkHelper.ClickOnLink(By.XPath("//dt[@id='parameters']/a"));
            //ObjectRepository.Driver.FindElement(By.Id("ssl_redirect-on")).Click();
            Console.WriteLine("Selected {0}", RadioButtonHelper.IsRadioButtonSelected(By.Id("ssl_redirect-on")));
            RadioButtonHelper.ClickRadioButton(By.Id("ssl_redirect-on"));

        }
    }
}
