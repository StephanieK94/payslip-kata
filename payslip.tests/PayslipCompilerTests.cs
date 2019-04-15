using Payslip;
using Xunit;

namespace payslip.tests
{
    public class PayslipCompilerTests
    {
        [Fact]
        public void GivenEmployeeInformationCalculateCalculationInformationAndCompileStrings()
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

            var compiler = new PayslipCompiler();

            var outputStatement = compiler.CompileStrings(employee, calculation);

            Assert.Equal("David Rudd,01 March – 31 March,5004,922,4082,450", outputStatement);
        }
    }
}
