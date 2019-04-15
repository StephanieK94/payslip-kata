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
            employee.Salary = 60050M;
            employee.PayRate = 9M;
            employee.PayPeriod = "01 March – 31 March";

            var calculator = new TaxIncomeCalculations();
            
            calculation = calculator.GetCalculations(employee);

            Assert.Equal(5004, calculation.GrossIncome);
            Assert.Equal(922, calculation.IncomeTax);
            Assert.Equal(4082, calculation.NetIncome);
            Assert.Equal(450, calculation.SuperAmount);
        }

        [Fact]
        public void GivenDecimalNumberGetsRoundedNumberToNearestInteger()
        {
            decimal pointFourNine = 10.49M;
            decimal pointFive = 10.5M;
            decimal pointFiveOne = 10.51M;

            var rounder = new TaxIncomeCalculations();
            var roundDown = rounder.GetRoundedCalculationAsInteger(pointFourNine);
            var roundMiddleCalculation = rounder.GetRoundedCalculationAsInteger(pointFive);
            var roundUp = rounder.GetRoundedCalculationAsInteger(pointFiveOne);

            Assert.Equal(10, roundDown);
            Assert.Equal(11, roundMiddleCalculation);
            Assert.Equal(11, roundUp);
        }
    }
}
