using Payslip;
using Xunit;


namespace payslip.tests
{
    public class EmployeeDetailTests
    {
        [Fact]
        public void GivenEmployeeInformationAndCalculationInformationCompilesStrings()
        {
            var employee = new EmployeeInformation();
            var calculation = new CalculationInformation();

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
        public void GivenNameStringsReturnFullName()
        {
            var firstName = "David";
            var lastName = "Rudd";

            var fullNameCompiler = new PayslipCompiler();
            var fullName = fullNameCompiler.GetFullNameFrom(firstName, lastName);

            Assert.Equal("David Rudd", fullName);
        }
    }
}
