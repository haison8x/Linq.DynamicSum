using Linq.DynamicSum.UnitTests.TestModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class CalculateSummaryEntityUnitTestsTestCaseProvider : IEnumerable<ITestCaseData>
    {
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

        private static CalculateSummaryEntityUnitTestsTestsModel emptyListOfSimpleObjects = new CalculateSummaryEntityUnitTestsTestsModel
        {
            Input = new List<SimpleObject>(),
            Expected = new SummaryEntity<SimpleObject>()
            {
                Entities = new List<SimpleObject>(),
                Total = new SimpleObject()
            }
        };

        private static CalculateSummaryEntityUnitTestsTestsModel listOfSimpleObjects = new CalculateSummaryEntityUnitTestsTestsModel
        {
            Input = new List<SimpleObject> { simpleObjectItemFirst, simpleObjectItemSecond },
            Expected = new SummaryEntity<SimpleObject>
            {
                Entities = new List<SimpleObject> { simpleObjectItemFirst, simpleObjectItemSecond },
                Total = new SimpleObject
                {
                    Name = string.Empty,
                    Price = 0,
                    Quantity = 400
                }
            }
        };

        public IEnumerator<ITestCaseData> GetEnumerator()
        {
            yield return new TestCaseData(emptyListOfSimpleObjects)
                .SetName("CalculateSummaryEntity - emptyListOfSimpleObjects, Return default");
            yield return new TestCaseData(listOfSimpleObjects)
                .SetName("CalculateSummaryEntity - listOfSimpleObjects, Return right SummaryEntity object");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
