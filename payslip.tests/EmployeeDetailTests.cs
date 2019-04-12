using Payslip;
using Xunit;


namespace payslip.tests
{
    public class EmployeeDetailTests
    {
        [Fact]
        public void GivenEmployeeInformationAndCalculationInformationGetStringStatement()
        {
            EmployeeInformation employee = new EmployeeInformation();
            CalculationInformation calculation = new CalculationInformation();

            employee.FirstName = "David";
            employee.LastName = "Rudd";
            employee.Salary = "60050";
            employee.PayRate = "9%";
            employee.PayPeriod = "01 March – 31 March";

            calculation.GrossIncome = "5004";
            calculation.IncomeTax = "922";
            calculation.NetIncome = "4082";
            calculation.SuperAmount = "450";

            var compiler = new PayslipCompiler();

            var outputStatement = compiler.CompileStrings(employee, calculation);

            Assert.Equal("David Rudd,01 March – 31 March,5004,922,4082,450", outputStatement);
        }

        [Fact]
        public void GivenEmployeeInformationGetCalculationInformation()
        {
            EmployeeInformation employee = new EmployeeInformation();
            CalculationInformation calculation = new CalculationInformation();

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
        public void GivenNameStringsReturnFullName()
        {
            string firstName = "David";
            string lastName = "Rudd";

            var fullNameCompiler = new PayslipCompiler();
            string fullName = fullNameCompiler.GetFullNameFrom(firstName, lastName);

            Assert.Equal("David Rudd", fullName);
        }

        [Fact]
        public void GivenPayRateStringGetTrimmedString()
        {
            var payRate = "9%";

            var superRate = payRate.Trim('%');

            Assert.Equal("9", superRate);
        }
    }
}
