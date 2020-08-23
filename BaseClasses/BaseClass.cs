using BankingProject.ComponentHelper.BrowserHelper;
using BankingProject.Configuration;
using BankingProject.CustomException;
using BankingProject.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BankingProject.BaseClasses
{
    [TestClass]
    public class BaseClass
    {
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        public static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;

        }
        public static IWebDriver GetIExplorerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            return driver;
        }
        
        
        

        [AssemblyInitialize]
        public static void Initwebdriver(TestContext tc)
        {
            ObjectRepository.config = new AppConfigReader();
            switch(ObjectRepository.config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIExplorerDriver();
                    break;
                

                default:
                    throw new NoSuitableDriverFound("Driver not found: {0}", ObjectRepository.config.GetBrowser().ToString());

            }
            BrowserActionsHelper.BrowserMaximize();
            ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(ObjectRepository.config.GetPageLoadTimeOut());
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(ObjectRepository.config.GetElementLoadTimeOut());
            
        }
        [AssemblyCleanup]
        public static void TearDown()
        {
            if(ObjectRepository.Driver!=null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
                
            }
         }
    }
}
