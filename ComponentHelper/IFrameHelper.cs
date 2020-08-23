using BankingProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
    public class IFrameHelper
    {
        public static void SwitchToFrameId(By Locator)
        {
            ObjectRepository.Driver.SwitchTo().Frame(GenericHelper.GetElement(Locator));
        }
        public static void SwitchToDefaultContent()
        {
            ObjectRepository.Driver.SwitchTo().DefaultContent();
        }

        
    }
}
