using NUnit.Asserts.Compare;
using NUnit.Framework;

namespace Linq.DynamicSum.UnitTests
{
    public class SumSimpleObjectUnitTests
    {
        [TestCaseSource(typeof(SumSimpleObjectUnitTestsTestCaseProvider))]
        public void DynamicSum_ListOfSimpleObjects_ReturnsSumValue(SumSimpleObjectUnitTestsModel dataTest)
        {
            var actualResult = dataTest.Input.DynamicSum();

            Assert.That(actualResult, Compares.To(dataTest.Expected));
        }
    }
}
