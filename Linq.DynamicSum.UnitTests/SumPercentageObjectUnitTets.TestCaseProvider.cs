using Linq.DynamicSum.UnitTests.TestModel;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace Linq.DynamicSum.UnitTests
{
    public class SumPercentageObjectUnitTetsTestCaseProvider : IEnumerable<ITestCaseData>
    {
        private static PercentageObject expectedPercentageObjects = new PercentageObject
        {
            Product = "Sportbook",
            Turnover = 40,
            WinLost = 130
        };

        private static PercentageObject percentageObjectItemFirst = new PercentageObject
        {
            Product = "Sportbook",
            Turnover = 10,
            WinLost = 90
        };

        private static PercentageObject percentageObjectsItemSecond = new PercentageObject
        {
            Product = string.Empty,
            Turnover = 30,
            WinLost = 40
        };

        private static PercentageObject percentageObjectsItemThird = new PercentageObject
        {
            Product = string.Empty,
            Turnover = 0,
            WinLost = 40
        };

        private static SumPercentageObjectUnitTestsModel emptyListOfPercentageObjects = new SumPercentageObjectUnitTestsModel
        {
            Input = new List<PercentageObject>(),
            Expected = new PercentageObject()
        };

        private static SumPercentageObjectUnitTestsModel listOfPercentageObjects = new SumPercentageObjectUnitTestsModel
        {
            Input = new List<PercentageObject> { percentageObjectItemFirst, percentageObjectsItemSecond },
            Expected = expectedPercentageObjects
        };

        public IEnumerator<ITestCaseData> GetEnumerator()
        {
            yield return new TestCaseData(emptyListOfPercentageObjects)
                .SetName("emptyListOfPercentageObjects, Return default");
            yield return new TestCaseData(listOfPercentageObjects)
                .SetName("listOfPercentageObjects, Return right sum percentage object");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
