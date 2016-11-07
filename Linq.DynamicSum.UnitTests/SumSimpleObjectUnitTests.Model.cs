using Linq.DynamicSum.UnitTests.TestModel;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class SumSimpleObjectUnitTestsModel
    {
        public IEnumerable<SimpleObject> Input { get; set; }

        public SimpleObject Expected { get; set; }
    }
}
