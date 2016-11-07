using NUnit.Asserts.Compare;
using NUnit.Framework;

namespace Linq.DynamicSum.UnitTests
{
    public class SumPercentageObjectUnitTests
    {
        [TestCaseSource(typeof(SumPercentageObjectUnitTetsTestCaseProvider))]
        public void ListOfPercentageObjects_ReturnsRightResult(SumPercentageObjectUnitTestsModel dataTest)
        {
            var actualResult = dataTest.Input.DynamicSum();

            Assert.That(actualResult, Compares.To(dataTest.Expected));
        }
    }
}
