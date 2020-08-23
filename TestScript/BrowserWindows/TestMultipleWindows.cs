using BankingProject.ComponentHelper;
using BankingProject.ComponentHelper.BrowserHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.BrowserWindows
{
    [TestClass]
    public class TestMultipleWindows
    {
        [TestMethod]
        public void TestWindows()
        {
            NavigationHelper.NavigateToUrl("http://omayo.blogspot.com/");
            LinkHelper.ClickOnLink(By.XPath("//a[text()='SeleniumTutorial']"));
            BrowserActionsHelper.SwitchToWindow(1);
            Console.WriteLine(ObjectRepository.Driver.Title);
            LinkHelper.ClickOnLink(By.LinkText("What is Selenium?"));
            BrowserActionsHelper.SwitchToParent();

            LinkHelper.ClickOnLink(By.LinkText("Open a popup window"));
            BrowserActionsHelper.SwitchToWindow(1);
            Console.WriteLine(ObjectRepository.Driver.Title);

           BrowserActionsHelper.SwitchToParent();
        }
        
    }
}
