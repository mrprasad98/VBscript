using BankingProject.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Settings
{
    public class ObjectRepository
    {
        public static IConfig config { set; get; }
        public static IWebDriver Driver { set; get; }
    }
}
