using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailPoint.Base
{
    public abstract class TestCase 
    {
        public virtual TestResults AutomationTest()
        {
            return new TestResults
            {
                Actual = false
            };
        }
    }
}
