using Payslip;
using Xunit;

namespace payslip.tests
{
    public class PayslipBuilderTests
    {
        [Fact]
        public void GivenEmployeeInformationCalculateCalculationInformationAndCompileStrings()
        {
            var employee = new EmployeeInformation
            {
                FirstName = "David",
                LastName = "Rudd",
                Salary = 60050M,
                PayRate = 9M,
                PayPeriod = "01 March – 31 March"
            };

            var calculator = new TaxIncomeCalculations();

            var calculationInformation = calculator.GetCalculations(employee);

            var payslipBuilder = new PayslipBuilder();

            var employeePayslip = payslipBuilder.BuildPayslip(employee);

            Assert.Equal("David Rudd", employeePayslip.FullName);
            Assert.Equal("01 March – 31 March", employeePayslip.PayPeriod);
            Assert.Equal(5004M, employeePayslip.GrossIncome);
            Assert.Equal(922M, employeePayslip.IncomeTax);
            Assert.Equal(4082M, employeePayslip.NetIncome);
            Assert.Equal(450M, employeePayslip.SuperAmount);
        }
    }
}
