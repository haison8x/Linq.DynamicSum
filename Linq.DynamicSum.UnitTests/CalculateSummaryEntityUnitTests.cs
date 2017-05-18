using NUnit.Asserts.Compare;
using NUnit.Framework;

namespace Linq.DynamicSum.UnitTests
{
    public class CalculateSummaryEntityUnitTests
    {
        [TestCaseSource(typeof(CalculateSummaryEntityUnitTestsTestCaseProvider))]
        public void CalculateSummaryEntity_ListOfSimpleObjects_ReturnsRightSummaryEntity(CalculateSummaryEntityUnitTestsTestsModel dataTest)
        {
            var actualResult = dataTest.Input.CalculateSummaryEntity();

            Assert.That(actualResult, Compares.To(dataTest.Expected));
        }
    }
}
