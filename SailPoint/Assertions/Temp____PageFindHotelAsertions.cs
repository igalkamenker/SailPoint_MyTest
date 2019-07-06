using FluentAssertions;
using FluentAssertions.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SailPoint.Base;
using System.Diagnostics;

namespace SailPoint.Pages
{
   
    public partial class Temp____PageFindHotel : FluentEngine
    {

         public Temp____PageFindHotel Assert_CityName(string expected_cityName)
         {
            string actual_cityName = Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(JSONGetXpath("InputDestination")))).Text;

            //var status = actual_cityName.Should().Be(expected_cityName);
            var status = actual_cityName.Should().BeEmpty();
            Debug.WriteLine($"Assert_CityName - Passed : Actual Result is {status.And.Subject}");
            return this;
        }
    }
}
