using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SailPoint.Base;

namespace SailPoint.Pages
{
   
    public partial class Temp____PageSearchResults : FluentEngine
    {

        public override T GoToPage<T>()
        {
            Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("LinkFindActivities")))).Click();

            return new T();
        }

        public Temp____PageSearchResults StepDescription(string stepDescription)
        {
            return this;
        }
     
       







    }
}
