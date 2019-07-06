using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SailPoint.Base;
using System.Threading;

namespace SailPoint.Pages
{
   
    public partial class Temp____PageFindHotel : FluentEngine
    {
        public Temp____PageFindHotel StepDescription(string stepDescription)
        {
            return this;
        }

        public Temp____PageFindHotel EnterDestination(string destination)
        {
            IWebElement elem;
            
            elem = Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("InputDestination"))));
            elem.SendKeys("New York");

            new WebDriverWait(WebDriver, ElementSearchingTimeout)
              .Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("DestinationDropDownMenu_1stOption")))).Click();
            return this;
        }

        public Temp____PageFindHotel Selectmounth(string month)
        {
            for (int i = 0; i < 14; i++)
            {
                IWebElement elem = new WebDriverWait(WebDriver, ElementSearchingTimeout)
                        .Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(JSONGetXpath("CalendarMounth"))))[0];

                if (elem.Text.Contains(month))
                {
                    break;
                }

                new WebDriverWait(WebDriver, ElementSearchingTimeout)
                   .Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("CalendarNavigateMounth")))).Click();
            }

            return this;
        }

        // "BtnFindHotels": "//span[text()='Hotels']"
        public override T GoToPage<T>() 
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("BtnFindHotels")))).Click();
            
            return new T();
        }








    }
}
