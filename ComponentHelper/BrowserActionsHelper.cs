using BankingProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper.BrowserHelper
{
    public class BrowserActionsHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }
        public static void GoBack()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
        public static void GoForward()
        {
            ObjectRepository.Driver.Navigate().Forward();
        }
        public static void Refresh()
        {
            ObjectRepository.Driver.Navigate().Refresh();
        }
        public static void SwitchToWindow(int index=0)
        {
            ReadOnlyCollection<String> windowids = ObjectRepository.Driver.WindowHandles;
            if(windowids.Count<index)
            {
                throw new NoSuchWindowException("Invalid browser window"+index);
            }
            ObjectRepository.Driver.SwitchTo().Window(windowids[index]);
            BrowserMaximize();

        }
        public static void SwitchToParent(int index=0)
        {
            var windowids = ObjectRepository.Driver.WindowHandles;

            if(windowids.Count>index)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.SwitchTo().Window(windowids[index]);
            }
            
                    }
        
    }
}
