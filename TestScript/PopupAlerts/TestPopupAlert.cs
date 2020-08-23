using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.PopupAlerts
{
    [TestClass]
    public class TestPopupAlert
    {
        [TestMethod]
        public void TestAlert()
        {
            NavigationHelper.NavigateToUrl("http://omayo.blogspot.com/");
            ButtonHelper.ClickButton(By.Id("alert1"));
            PopupHelper.IsAlertPresent();
            PopupHelper.GetText();
            PopupHelper.ClickOkButton();
                    }
        [TestMethod]
        public void TestPrompt()
        {
            NavigationHelper.NavigateToUrl("http://omayo.blogspot.com/");
            ButtonHelper.ClickButton(By.Id("prompt"));
           // PopupHelper.IsAlertPresent();
            ObjectRepository.Driver.SwitchTo().Alert().SendKeys("raju");
            //PopupHelper.TypeText("Rajendra");
            PopupHelper.ClickOkButton();
        }
        [TestMethod]
        public void TestConfirmation()
        {
            NavigationHelper.NavigateToUrl("http://omayo.blogspot.com/");
            ButtonHelper.ClickButton(By.Id("confirm"));
            PopupHelper.ClickCancelButton();

            
        }
    }
}
