using Payslip;
using Xunit;

namespace payslip.tests
{
    public class CalculationTests
    {
        [Fact]
        public void GivenDecimalNumberGetsRoundedNumberToNearestInteger()
        {
            var pointFourNine = 10.49;
            var pointFive = 10.5;
            var pointFiveOne = 10.51;

            var rounder = new Calculation();
            var roundDown = rounder.GetRoundedCalculationAsInteger(pointFourNine);
            var roundMiddleCalculation = rounder.GetRoundedCalculationAsInteger(pointFive);
            var roundUp = rounder.GetRoundedCalculationAsInteger(pointFiveOne);

            Assert.Equal(10, roundDown);
            Assert.Equal(11, roundMiddleCalculation);
            Assert.Equal(11, roundUp);
        }
    }
}
