using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Framework
{
    public class NewsPage
    {
        private const string newsElement = "Latest News";

        public static bool isAtNewsPage()
        {
            if (Main.DriverInstance.FindElements(By.LinkText(newsElement)).Count >= 1)
                return true;
            return false;
        }
    }
}
