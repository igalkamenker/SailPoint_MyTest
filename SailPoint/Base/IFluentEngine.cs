using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailPoint.Base
{

    public interface IFluentEngine : IDisposable
    {
        IWebDriver WebDriver { get; }
        T GoToPage<T>(string url) where T : new();
        T GoToPage<T>() where T : new();

       WebDriverWait Wait { get; }
        IWebElement GetElementIsVisibleLocatedBy(string xpath);
        

        }
    
}
