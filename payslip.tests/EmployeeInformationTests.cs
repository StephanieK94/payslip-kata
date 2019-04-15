using Payslip;
using Xunit;

namespace payslip.tests
{
    public class EmployeeInformationTests
    {
        [Fact]
        public void ReadEmployeeInformationAndSplitString()
        {
            var employee = "David,Rudd,60050,9%,01 March – 31 March";

            var splittingTool = new Splitter();

            var splitEmployee = splittingTool.SplitString(employee);

            Assert.Equal("David", splitEmployee.FirstName);
            Assert.Equal("Rudd", splitEmployee.LastName);
            Assert.Equal(60050M, splitEmployee.Salary);
            Assert.Equal("9%", splitEmployee.PayRate);
            Assert.Equal("01 March – 31 March", splitEmployee.PayPeriod);
        }
    }

    public class Splitter
    {
        public EmployeeInformation SplitString(string employee)
        {

            var foo = employee.Split(',');

            var employeeInformation = new EmployeeInformation
            {
                FirstName = foo[0],
                LastName = foo[1],
                Salary = decimal.Parse(foo[2]),
                PayRate = foo[3],
                PayPeriod = foo[4]
            };


            return employeeInformation;
        }
    }
}
