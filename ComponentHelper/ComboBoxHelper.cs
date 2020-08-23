using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
   public class ComboBoxHelper
    {
        private static SelectElement select;
        public static void SelectIndex(By Locator, int index)
        {
             select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByIndex(index);
        }

        public static void SelectText(By Locator, String text)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            select.SelectByText(text);
        }

        public static IList<String> GetAllItems(By Locator)
        {
            select = new SelectElement(GenericHelper.GetElement(Locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
        public static void SelectElement(IWebElement element, String text )
        {
            select = new SelectElement(element);
            select.SelectByValue(text);
        }
        public static void SelectIndex(IWebElement element, int index)
        {
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }
    }
}
