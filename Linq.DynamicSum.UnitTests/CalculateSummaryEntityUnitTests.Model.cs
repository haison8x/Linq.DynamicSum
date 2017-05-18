using Linq.DynamicSum.UnitTests.TestModel;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class CalculateSummaryEntityUnitTestsTestsModel
    {
        public IEnumerable<SimpleObject> Input { get; set; }

        public SummaryEntity<SimpleObject> Expected { get; set; }
    }
}
