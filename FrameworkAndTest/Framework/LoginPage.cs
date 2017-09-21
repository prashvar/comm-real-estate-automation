using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class LoginPage
    {
        public static bool isAtLoginPage()
        {
            if (Main.DriverInstance.FindElements(By.XPath("//h2[.='Sign into Commercial Real Estate']")).Count == 1)
                return true;
            return false;
        }        
    }
}
