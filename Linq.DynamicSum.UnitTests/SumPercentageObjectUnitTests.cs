using NUnit.Asserts.Compare;
using NUnit.Framework;

namespace Linq.DynamicSum.UnitTests
{
    public class SumPercentageObjectUnitTests
    {
        [TestCaseSource(typeof(SumPercentageObjectUnitTetsTestCaseProvider))]
        public void DynamicSum_ListOfPercentageObjects_ReturnsRightSumValue(SumPercentageObjectUnitTestsModel dataTest)
        {
            var actualResult = dataTest.Input.DynamicSum();

            Assert.That(actualResult, Compares.To(dataTest.Expected));
        }
    }
}
