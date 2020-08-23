using BankingProject.ComponentHelper;
using BankingProject.ComponentHelper.BrowserHelper;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.TestScript.IFrame
{
    [TestClass]
    public class TestIframe
    {
        [TestMethod]
        public void TestFrame()
        {
            NavigationHelper.NavigateToUrl("http://omayo.blogspot.com/");
            IFrameHelper.SwitchToFrameId(By.Id("iframe2"));
            LinkHelper.ClickOnLink(By.XPath("//a[text()='Chapter1']"));
            RadioButtonHelper.ClickRadioButton(By.Id("radiobutton"));
            CheckBoxHelper.CheckedCheckBox(By.XPath("//select[@id='selecttype']/following-sibling::input"));
            ComboBoxHelper.SelectIndex(By.Id("selecttype"), 2);
            IFrameHelper.SwitchToDefaultContent();
            Console.WriteLine(ObjectRepository.Driver.Title);


        }
    }
}
