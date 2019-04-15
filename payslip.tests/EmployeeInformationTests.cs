using System.IO;
using Payslip;
using Xunit;

namespace payslip.tests
{
    public class EmployeeInformationTests
    {
        [Fact]
        public void ReadCsvInformationAndSplitString()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";
            var parser = new CsvParser();

            var employeeList = parser.GetCsvContents(pathName);

            Assert.Equal("David", employeeList[0].FirstName);
            Assert.Equal("Rudd", employeeList[0].LastName);
            Assert.Equal(60050M, employeeList[0].Salary);
            Assert.Equal(9, employeeList[0].PayRate);
            Assert.Equal("01 March – 31 March", employeeList[0].PayPeriod);
        }
    }
}
