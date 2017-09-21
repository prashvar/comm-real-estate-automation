using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class FranchisePage
    {

        private const string headlineElement = "franchise-home__headline";

        public static bool isAtFranchiseSalePage()
        {
            String headline = Main.DriverInstance.FindElement(By.ClassName(headlineElement)).Text;
            if (headline.Equals("Find the right franchise for you."))
                return true;
            return false;
        }
    }
}
