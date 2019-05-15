using System.Collections.Generic;
using Payslip;
using Xunit;

namespace employee.tests
{
    public class PayslipBuilderTests
    {
        [Fact]
        public void GivenEmployeeInformationCalculateCalculationInformationAndCompileStrings()
        {
            var listEmployees = new List<Employee>();

            var employee = new Employee
            {
                FirstName = "David",
                LastName = "Rudd",
                Salary = 60050M,
                PayRate = 9M,
                PayPeriod = "01 March – 31 March"
            };

            listEmployees.Add(employee);

            var payslipBuilder = new PayslipBuilder();

            var employeePayslip = payslipBuilder.BuildPayslip(listEmployees);

            Assert.Equal("David Rudd", employeePayslip[0].FullName);
            Assert.Equal("01 March – 31 March", employeePayslip[0].PayPeriod);
            Assert.Equal(5004M, employeePayslip[0].GrossIncome);
            Assert.Equal(922M, employeePayslip[0].IncomeTax);
            Assert.Equal(4082M, employeePayslip[0].NetIncome);
            Assert.Equal(450M, employeePayslip[0].SuperAmount);
        }
    }
}
