using Payslip;
using Xunit;


namespace payslip.tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenStringGetEmployeeDetailsAsArray()
        {
            var testEmployee = new []{ "David", "Rudd", "60050", "9%", "01 March - 31 March" };

            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new CommaSeparator();

            var employeeDetails = commaSeparator.GetEmployeeDetailsFrom(employeeFile);

            Assert.Equal(testEmployee, employeeDetails);
        }

        [Fact]
        public void GivenStringGetFirstName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new CommaSeparator();

            var firstName = commaSeparator.GetFirstNameFrom(employeeFile);

            Assert.Equal("David", firstName);
        }

        [Fact]
        public void GivenStringGetLastNameName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparation = new CommaSeparator();

            var lastName = commaSeparation.GetLastNameFrom(employeeFile);

            Assert.Equal("Rudd", lastName);
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
