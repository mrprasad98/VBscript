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

namespace BankingProject.TestScript.FindElements
{
    [TestClass]
    public class HandleElements
    {
        [TestMethod]
        public void TestElements()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            ReadOnlyCollection<IWebElement> collection=ObjectRepository.Driver.FindElements(By.XPath("//input"));
            foreach(var temp in collection)
            {
                Console.WriteLine("input tags are: {0}", temp.GetAttribute("id"));
            }
        }
    }
}
