using Linq.DynamicSum.UnitTests.TestModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class SumSimpleObjectUnitTestsTestCaseProvider : IEnumerable<ITestCaseData>
    {
        private static SimpleObject expectedSimpleObject = new SimpleObject
        {
            Name = string.Empty,
            Price = 0,
            Quantity = 400
        };

        private static SimpleObject simpleObjectItemFirst = new SimpleObject
        {
            Name = "Soccer",
            Price = 100,
            Quantity = 150
        };

        private static SimpleObject simpleObjectItemSecond = new SimpleObject
        {
            Name = string.Empty,
            Price = 50,
            Quantity = 250
        };

        private static SumSimpleObjectUnitTestsModel emptyListOfSimpleObjects = new SumSimpleObjectUnitTestsModel
        {
            Input = new List<SimpleObject>(),
            Expected = new SimpleObject()
        };

        private static SumSimpleObjectUnitTestsModel listOfSimpleObjects = new SumSimpleObjectUnitTestsModel
        {
            Input = new List<SimpleObject> { simpleObjectItemFirst, simpleObjectItemSecond },
            Expected = expectedSimpleObject
        };

        public IEnumerator<ITestCaseData> GetEnumerator()
        {
            yield return new TestCaseData(emptyListOfSimpleObjects)
                .SetName("DynamicSum - emptyListOfSimpleObjects, Return default");
            yield return new TestCaseData(listOfSimpleObjects)
                .SetName("DynamicSum - listOfSimpleObjects, Return right sum object");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
