using BankingProject.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
   public class TakeScreenshot
    {
        

        public static void Screenshot(String filename="screen")
        {


            ITakesScreenshot screen = (ITakesScreenshot)ObjectRepository.Driver;
                
                if(filename.Equals("screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".Jpeg";
                screen.GetScreenshot().SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            else
            {
                screen.GetScreenshot().SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            }

        }
    }
}
