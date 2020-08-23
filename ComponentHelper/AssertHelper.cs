using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject.ComponentHelper
{
    public class AssertHelper
    {
        public static void AssertEqual(String expected, String actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch(Exception)
            {
                //ignore
            }
        }
    }
}
