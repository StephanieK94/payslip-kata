using Payslip;
using Xunit;


namespace payslip.tests
{
    public class EmployeeDetailTests
    {
        [Fact]
        public void GivenStringGetEmployeeDetails()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            string[] expectedEmployee = { "David" , "Rudd" , "60050" , "9%" , "01 March - 31 March" };

            var commaSeparator = new CommaSeparator();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal(expectedEmployee[0], employeeInformation.FirstName);
            Assert.Equal(expectedEmployee[1], employeeInformation.LastName);
            Assert.Equal(expectedEmployee[2], employeeInformation.EmployeeSalary);
            Assert.Equal(expectedEmployee[3], employeeInformation.EmployeePayRate);
            Assert.Equal(expectedEmployee[4], employeeInformation.PayPeriod);
        }

        [Fact]
        public void GivenStringReturnFullName()
        {
            string employeeFile = "David,Rudd,60050,9%,01 March - 31 March";

            var commaSeparator = new CommaSeparator();

            var employeeInformation = commaSeparator.GetEmployeeInformation(employeeFile);

            Assert.Equal("David Rudd", employeeInformation.FullName);
        }

        [Fact]
        public void GivenNumberStringReturnNumber()
        {
            string salary = "60050";

            var converter = new StringToNumberConverter();

            var salaryNumber = converter.ConvertStringToNumber(salary);

            Assert.Equal(60050, salaryNumber);
        }

        [Fact]
        public void GivenLessThanPointFiveNumberRoundsDownToNearestInteger()
        {
            double calculation = 10.4d;

            var rounder = new CalculationRounder();

            var roundDown = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(10.0, roundDown);
        }

        [Fact]
        public void GivenPointFiveOrAboveNumberRoundsUpToNearestInteger()
        {
            double calculation = 10.5d;

            var rounder = new CalculationRounder();

            var point5 = rounder.GetRoundedCalculation(calculation);
            var point75 = rounder.GetRoundedCalculation(calculation);

            Assert.Equal(11, point5);
            Assert.Equal(11, point75);
        }

        [Fact]
        public void GivenPayRateStringGetTrimmedString()
        {
            string payRate = "9%";

            var calculator = new CalculationRounder();

            var rate = calculator.GetTrimmedNumber(payRate);

            Assert.Equal("9", rate);
        }
    }

    public class StringToNumberConverter
    {
        public double ConvertStringToNumber(string salary)
        {
            var salaryString = salary;

            var value = double.Parse(salaryString);

            return value;
        }
    }
}
