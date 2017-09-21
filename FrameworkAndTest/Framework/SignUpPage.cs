using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class SignUpPage
    {
        private const string signupElement = "//div[@class='screen-wrapper']/a[.='Sign up with email']";

        public static bool isAtSignUpPage()
        {
            if (Main.DriverInstance.FindElements(By.XPath(signupElement)).Count == 1)
                return true;
            return false;
        }        
    }
}
