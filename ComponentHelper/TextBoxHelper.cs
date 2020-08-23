using BankingProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
   public class TextBoxHelper
    {
        private static IWebElement element;
        public static void TypeInTextBox(By Locator, String text)
        {
            element = GenericHelper.GetElement(Locator);
            element.SendKeys(text);
        }

        public static void ClearTextBox(By Locator)
        {
            element=GenericHelper.GetElement(Locator);
            element.Clear();
        }

        internal static void TypeInTextBox(object p1, object p2)
        {
            throw new NotImplementedException();
        }
    }
}
