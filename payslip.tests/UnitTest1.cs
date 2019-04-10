using Payslip;
using Xunit;


namespace payslip.tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenStringGetEmployeeDetails()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new CommaSeparator();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);
            
            Assert.Equal("David", employeeInformation.FirstName);
            Assert.Equal("Rudd", employeeInformation.LastName);
            Assert.Equal("01 March - 31 March", employeeInformation.PayPeriod);

        }

        [Fact]
        public void GivenStringGetFullName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparation = new CommaSeparator();

            var fullName = commaSeparation.GetFullNameFrom(employeeFile);

            Assert.Equal("David Rudd", fullName);
        }

        [Fact]
        public void GivenNumberRoundsDownToNearestWholeInteger()
        {
            double calculation = 10.4d;

            var rounder = new CalculationRounder();

            var roundDown = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(10.0, roundDown);
        }

        [Fact]
        public void GivenPointFiveNumberRoundsUpToNearestWholeInteger()
        {
            double calculation = 10.5d;

            var rounder = new CalculationRounder();

            var roundsUp = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(11, roundsUp);
        }

        
    }
}
