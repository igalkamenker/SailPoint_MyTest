using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SailPoint.Extentions;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace SailPoint.Base
{
    public class FluentEngine : IFluentEngine
    {
        public string MainWindow = null;
       public FluentEngine() { }
        public FluentEngine(IWebDriver webDriver)//done
        {
            m_WebDriver = webDriver;
        }

        private static IWebDriver m_WebDriver;//done

        public  IWebDriver WebDriver => m_WebDriver;

        public virtual IDictionary<string, string> Repository { get; }

        public static TimeSpan ElementSearchingTimeout { get; set; } = TimeSpan.FromSeconds(20); //assign default value 

        public T GoToPage<T>(string url) where T : new() //done
        {

            WebDriver.NavigateToUrl(url);
            MainWindow = WebDriver.WindowHandles.ToList<string>()[0];
            return new T();

        }
       public virtual T GoToPage<T>()  where T : new()
        {
            return new T();
        }
        public virtual T ButtonClickGoTo<T>(string xPathName) where T : new()
        {
           
            return new T();
        }

        public virtual T LinkClickGoTo<T>(string xPathName) where T : new()
        {

            return new T();
        }

        public void Dispose()
        {
            m_WebDriver?.Dispose();
        }


        public WebDriverWait Wait
        {
            get
            {
                return new WebDriverWait(WebDriver, ElementSearchingTimeout);
            }
        }

        public IWebElement GetElementIsVisibleLocatedBy(string xpath)
        {
            IWebElement webElement = null;
            int cycle = 0;
            while (cycle < 50)
            {
                try
                {

                    webElement = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                    return webElement;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Try again - > ClickWithWaitPresenceOfAllElementsLocatedBy", e.Source);
                    Thread.Sleep(100);
                }
                cycle++;


            }
            if (cycle >= 45)
                throw new NoSuchElementException();
            return webElement;
        }


        public  string JSONGetXpath (string ElementByName)
        { 
            dynamic JSONobject = JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + $"\\JsonPageEments\\{GetType().Name}.json"));
            return JToken.Parse(JSONobject.ToString())[ElementByName];
        }

        public string JSONGetXpath(string ElementByName,string ClassName)
        {
            dynamic JSONobject = JsonConvert.DeserializeObject(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)) + $"\\JsonPageEments\\{ClassName}.json"));
            return JToken.Parse(JSONobject.ToString())[ElementByName];
        }

        
    }

}

