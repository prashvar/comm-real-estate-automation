using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class HomePage
    {
        public static void goToHome()           //Navigate to the target page
        {
            Main.DriverInstance.Navigate().GoToUrl("https://www.commercialrealestate.com.au/");
        }
        public static void GoToTab(String text)
        {
            var elementLocation = Main.DriverInstance.FindElement(By.LinkText(text));
            elementLocation.Click();            
        }
               
        public static bool isAtPropertyOrHomePage()
        {
            var elements = Main.DriverInstance.FindElements(By.ClassName("homepage-tag-line"));
            if (elements.Count >= 1)
                return true;
            return false;
        }
    }
}
