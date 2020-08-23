using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.WebDriverWait
{
    [TestClass]
   public class TestWebDriverWait
    {
        [TestMethod]
        public void TestWait()
        {

            
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            TextBoxHelper.TypeInTextBox(By.Id("quicksearch_top"), "C#");
            TextBoxHelper.TypeInTextBox(By.Id("quicksearch_bottom"), "Specflow");
        }

    }
}
