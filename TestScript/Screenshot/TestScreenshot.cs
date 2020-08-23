using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.Events;


namespace BankingProject.TestScript.Screenshot
{
    [TestClass]
    public class TestScreenshot
    {
        [TestMethod]
        public void GetScreenshot()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            TakeScreenshot.Screenshot("rajendra.Jpeg");
            LinkHelper.ClickOnLink(By.Id("enter_bug"));
            TakeScreenshot.Screenshot("Prasad.Jpeg");
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.config.GetUsername());
            TakeScreenshot.Screenshot("Modem.Jpeg");
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.config.GetPassword());
            TakeScreenshot.Screenshot("India.Jpeg");
            //TakeScreenshot.Screenshot("rajendra.png");

            

        }
    }
}
