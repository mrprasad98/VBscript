using BankingProject.Interfaces;
using BankingProject.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            String browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public int GetElementLoadTimeOut()
        {
            String timeout=ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeOut);
            if(timeout==null)
            {
                return 20;
            }
            else
            {
                return Convert.ToInt32(timeout);
            }
        }

        public int GetPageLoadTimeOut()
        {
            String timeout=ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeOut);
            if(timeout==null)
            {
                return 30;
                            }
            else
            {
                return Convert.ToInt32(timeout);
            }
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);

        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
