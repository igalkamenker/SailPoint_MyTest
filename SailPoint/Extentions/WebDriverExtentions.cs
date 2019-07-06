using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailPoint.Extentions
{
    public static class WebDriverExtentions
    {
        public static IWebDriver NavigateToUrl(this IWebDriver webDriver, string url)
        {
            webDriver.Navigate().GoToUrl(url);
            webDriver.Manage().Window.Maximize();
            return webDriver;
        }
    }
}
