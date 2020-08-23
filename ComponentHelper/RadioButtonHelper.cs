using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
    public class RadioButtonHelper
            {
        private static IWebElement element;
        public static void ClickRadioButton(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }
        public static bool IsRadioButtonSelected(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            String flag=element.GetAttribute("Checked");
            Console.WriteLine("Text is: {0}", element.Text);
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("Checked");

        }
    }
}
