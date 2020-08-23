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

namespace BankingProject.TestScript.MouseActions
{
    [TestClass]
    public class TestMouseActions
    {
        [TestMethod]
        public void RightClick()
        {
            NavigationHelper.NavigateToUrl("https://demos.telerik.com/kendo-ui/dragdrop/index");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement ele = GenericHelper.GetElement(By.Id("draggable"));
            
            act.ContextClick().Build().Perform();
            Thread.Sleep(2000);
        }

        [TestMethod]
        public void DragNDrop()
        {
            NavigationHelper.NavigateToUrl("http://demo.guru99.com/test/drag_drop.html");
            Actions act = new Actions(ObjectRepository.Driver);
            IWebElement source=GenericHelper.GetElement(By.XPath("//*[@id='credit2']/a"));
            IWebElement target = GenericHelper.GetElement(By.XPath("//*[@id='bank']/li"));
            act.DragAndDrop(source, target)
                .Build()
                .Perform();
            Thread.Sleep(4000);
            
        }
        
    }
}
