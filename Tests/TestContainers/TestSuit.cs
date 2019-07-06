
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SailPoint.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.TestCases;

namespace Tests.TestContainers
{
    [TestClass]
    public class TestSuit
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void FindHotel_Negative()
        {
            TestResults testResult = new TC01_FindHotel().AutomationTest();
            Assert.IsTrue(testResult.Actual);
           
        }

        [TestMethod]
        public void FindHotel_Positive()
        {
            TestResults testResult = new TC02_FindHotel().AutomationTest();
            Assert.IsTrue(testResult.Actual);

        }
    }
}
