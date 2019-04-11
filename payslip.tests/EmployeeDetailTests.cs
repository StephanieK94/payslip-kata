using Payslip;
using Xunit;


namespace payslip.tests
{
    public class EmployeeDetailTests
    {
        //[Fact]
        //public void GivenStringArrayOutputsStringStatement()
        //{
        //    string[] employee = { "David Rudd", "01 March - 31 March", "5004", "922", "4082", "450" };

        //    var statement = new StatementCompiler();

        //    var employeeStatement = statement.CompileStrings(employee);

        //    Assert.Equal("David Rudd,01 March - 31 March,5004,922,4082,450", employeeStatement);
        //}

        [Fact]
        public void GivenEmployeeInformationGetStringStatement()
        {
            EmployeeInformation employee = new EmployeeInformation();
            employee.FullName = "David Rudd";
            employee.Salary = "60050";
            employee.PayRate = "9";
            employee.PayPeriod = "01 March – 31 March";
            employee.GrossIncome = "5004";
            employee.IncomeTax = "922";
            employee.NetIncome = "4082";
            employee.SuperAmount = "450";

            var compiler = new StatementCompiler();

            var outputStatement = compiler.CompileStrings(employee);

            Assert.Equal("David Rudd,01 March – 31 March,5004,922,4082,450", outputStatement);
        }

        [Fact]
        public void GivenNumberReturnString()
        {
            int grossIncome = 5004;

            var incomeInteger = new Calculation();

            var incomeString = incomeInteger.ToStringConverter(grossIncome);

            Assert.Equal("5004", incomeString);
        }

        [Fact]
        public void GivenNameStringsReturnFullName()
        {
            string firstName = "David";
            string lastName = "Rudd";

            var converter = new EmployeeDetails();
            string fullName = converter.GetFullNameFrom(firstName, lastName);

            Assert.Equal("David Rudd", fullName);
        }

        [Fact]
        public void GivenStringReturnNumber()
        {
            var salary = "60050";

            var converter = new Calculation();

            var salaryNumber = converter.ConvertStringToNumber(salary);

            Assert.Equal(60050, salaryNumber);
        }

        [Fact]
        public void GivenDecimalNumberGetsRoundedNumberToNearestInteger()
        {
            var pointFourNine = 10.49;
            var pointFive = 10.5;
            var pointFiveOne = 10.51;

            var rounder = new Calculation();

            var roundDown = rounder.GetRoundedCalculation(pointFourNine);
            var roundMiddleCalculation = rounder.GetRoundedCalculation(pointFive);
            var roundUp = rounder.GetRoundedCalculation(pointFiveOne);

            Assert.Equal(10, roundDown);
            Assert.Equal(11, roundMiddleCalculation);
            Assert.Equal(11, roundUp);
        }

        [Fact]
        public void GivenPayRateStringGetTrimmedString()
        {
            var payRate = "9%";

            var calculator = new Calculation();

            var rate = calculator.GetTrimmedNumber(payRate);

            Assert.Equal("9", rate);
        }

        [Fact]
        public void GivenIntReturnString()
        {
            int number = 500;
            var converter = new Calculation();

            var toString = converter.ToStringConverter(number);

            Assert.Equal("500", toString);
        }
    }
}
