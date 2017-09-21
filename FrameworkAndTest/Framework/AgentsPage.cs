using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class AgentsPage
    {
        private const string dropDownText = "//div[@class='primary-search-bar__button--light']";
        
        public static bool isAtAgentsPage()
        {
            String headline = Main.DriverInstance.FindElement(By.XPath(dropDownText)).Text;
            if (headline.Equals("Find Agent"))
                return true;
            return false;
        }
    }
}
