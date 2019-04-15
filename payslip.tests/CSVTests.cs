using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using Payslip;
using Xunit;

namespace payslip.tests
{
    public class CSVTests
    {
        [Fact]
        public void ReadCsvFileOutputEmployeeInformation()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";
            var parser = new CsvParser();

            var lineItems = parser.GetCsvContents(pathName);

            Assert.Equal("David", lineItems[0].FirstName);
        }
    }
}
