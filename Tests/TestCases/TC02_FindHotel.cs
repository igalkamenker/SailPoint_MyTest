using SailPoint.Base;
using SailPoint.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestCases
{
   public class TC02_FindHotel : FluentEngine
    {
        public TestResults AutomationTest()
        {

            var testResults = new TestResults { Actual = false, Exception = null };

            try
            {
                new FluentEngine(WebDriverFactory.GenerateWebDriver("chrome")).
                GoToPage<Temp____PageFindHotel>("https://www.lastminutetravel.com/").
                EnterDestination("new york").StepDescription("Insert City").
                Assert_CityName("New York").StepDescription("Verify displayed correct Name").
                Selectmounth("June").StepDescription("Select Reservation Day").
                GoToPage<Temp____PageSearchResults>().
                Assert_LinkActivites("ACTIVITIES").StepDescription("Verify link 'Activities' present on page").
                GoToPage<Temp____PageSearchActivites>();



                WebDriver.Dispose();
                testResults.Actual = true;
                return testResults;

            }
            catch (Exception e)
            {
                Debug.WriteLine($"Test Case {GetType().Name}  - Failed");
                testResults.Exception = e;
                Debug.WriteLine($"Source : {e.Source } \n Message: {e.Message}  \n StackTrace: {e.StackTrace}");
                WebDriver.Dispose();
                return testResults;
            }
        }
    }
}
