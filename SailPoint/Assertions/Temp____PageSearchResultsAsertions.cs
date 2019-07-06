using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SailPoint.Base;
using System.Diagnostics;

namespace SailPoint.Pages
{
   
    public partial class Temp____PageSearchResults : FluentEngine
    {

         public Temp____PageSearchResults Assert_LinkActivites(string expected_cityName)
         {
            string actual_cityName = Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("LinkFindActivities")))).Text;

            var status = actual_cityName.Should().Be(expected_cityName);
            Debug.WriteLine($"Assert_LinkActivite - Passed : Actual Result is {status.And.Subject}");
            return this;
        }
    }
}
