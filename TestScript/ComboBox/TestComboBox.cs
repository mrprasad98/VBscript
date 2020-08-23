using BankingProject.ComponentHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.ComboBox
{[TestClass]
    public class TestComboBox
    {
        [TestMethod]
        public void TestDropdownBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.config.GetWebsite());
            LinkHelper.ClickOnLink(By.Id("enter_bug"));
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_login"), ObjectRepository.config.GetUsername());
            TextBoxHelper.TypeInTextBox(By.Id("Bugzilla_password"), ObjectRepository.config.GetPassword());
            ButtonHelper.ClickButton(By.Id("log_in"));
            //IWebElement element= ObjectRepository.Driver.FindElement(By.Id("bug_severity"));
            // SelectElement select = new SelectElement(element);
            // select.SelectByIndex(3);
            // select.SelectByValue("trivial");
            // select.SelectByText("major");
            // Console.WriteLine("Selected Drop value is: {0}", select.SelectedOption.Text);
            // IList<IWebElement> list1=select.OptSions;
            // foreach(IWebElement temp in list1)
            // {
            //     Console.WriteLine("Value is: {0}, Text is: {1}", temp.GetAttribute("value"), temp.Text);
            // }
            ComboBoxHelper.SelectIndex(By.Id("bug_severity"), 5);
            ComboBoxHelper.SelectText(By.Id("bug_severity"), "major");
            ComboBoxHelper.SelectText(By.Id("bug_severity"), "trivial");
            foreach (String str in ComboBoxHelper.GetAllItems(By.Id("bug_severity")))
            {
                Console.WriteLine("TEXT IS: {0}", str);
            }

        }
    }
}
