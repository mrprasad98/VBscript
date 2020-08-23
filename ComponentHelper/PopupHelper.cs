using BankingProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
    public class PopupHelper
    {
        public static bool IsAlertPresent()
        {
            try
            {
                ObjectRepository.Driver.SwitchTo().Alert();
                return true;
            }
            catch(NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetText()
        {
            if(!IsAlertPresent())
            {
                return "";
                
            }
            else
                {
                return ObjectRepository.Driver.SwitchTo().Alert().Text;
            }
        }
        public static void ClickOkButton()
        {
            if (!IsAlertPresent())
            {
                return;
                
            }
            else
            {
                ObjectRepository.Driver.SwitchTo().Alert().Accept();
            }
            

        }
        public static void ClickCancelButton()
        {
            if(!IsAlertPresent())
                {
                return;
            }
            else
            {
                ObjectRepository.Driver.SwitchTo().Alert().Dismiss();
            }
        }
        public static void TypeText(String text)
        {
            if(!IsAlertPresent())
            {
                return;
            }
            else
            {
              IAlert alt= ObjectRepository.Driver.SwitchTo().Alert();
                alt.SendKeys(text);
            }
        }
    }
}
