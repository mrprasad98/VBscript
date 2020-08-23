using BankingProject.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
   public class WindowHelper
    {
        public static String GetTitle()
        {
            return ObjectRepository.Driver.Title;
        }
    }
}
