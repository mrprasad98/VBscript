using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.Button
{
    [TestClass]
   public class TestButton
    {[TestMethod]
        public void CheckButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            LinkHelper.ClickOnLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.config.GetPassword());
            Console.WriteLine("Text on the Button is: {0}", ButtonHelper.ButtonText(By.Id("log_in")));
            if(ButtonHelper.IsButtonEnabled(By.Id("log_in")))
            {
                ButtonHelper.ClickButton(By.Id("log_in"));
            }
            else
            {
                Console.WriteLine("Button not enabled");
            }
            
                        
        }
    }
}
