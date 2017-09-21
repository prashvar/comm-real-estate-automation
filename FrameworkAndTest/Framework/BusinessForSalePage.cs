using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class BusinessForSalePage
    {
        private const string headlineElement = "business-home__headline";
        
        public static bool isAtBusinessForSalePage()
        {

            String headline = Main.DriverInstance.FindElement(By.ClassName(headlineElement)).Text;
            if (headline.Equals("Be your own boss."))
                return true;
            return false;
        }
    }
}
