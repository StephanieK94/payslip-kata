using Payslip;
using Xunit;

namespace payslip.tests
{
    public class CalculationTests
    {
        [Fact]
        public void GivenEmployeeInformationGetsCalculations()
        {
            var employee = new EmployeeInformation();
            var calculation = new CalculationInformation();

            employee.FirstName = "David";
            employee.LastName = "Rudd";
            employee.Salary = "60050";
            employee.PayRate = "9%";
            employee.PayPeriod = "01 March – 31 March";

            var calculator = new Calculation();
            
            calculation = calculator.GetCalculations(employee);

            Assert.Equal("5004", calculation.GrossIncome);
            Assert.Equal("922", calculation.IncomeTax);
            Assert.Equal("4082", calculation.NetIncome);
            Assert.Equal("450", calculation.SuperAmount);
        }

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
