using Linq.DynamicSum.UnitTests.TestModel;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class SumPercentageObjectUnitTestsModel
    {
        public IEnumerable<PercentageObject> Input { get; set; }

        public PercentageObject Expected { get; set; }
    }
}
