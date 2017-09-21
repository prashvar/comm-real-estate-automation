using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;

namespace Framework
{
    public class Main
    {
        public static IWebDriver DriverInstance { get; set; }
                
        public static void CreateDriver()         //create a static instance of FF driver
        {
            DriverInstance = new FirefoxDriver();
            DriverInstance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void navigateBack()
        {
            DriverInstance.Navigate().Back();
        }

        public static void cleanup()
        {
            DriverInstance.Close();
        }
    }
}
