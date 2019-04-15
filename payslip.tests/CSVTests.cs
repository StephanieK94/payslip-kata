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
        public void ReadCsvFile()
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";
            var parser = new CsvParser();

            var lineItems = parser.GetCsvContents(pathName);

            Assert.Equal("David,Rudd,60050,9%,01 March – 31 March", lineItems[0]);
            Assert.Equal("Ryan,Chen,120000,10%,01 March – 31 March", lineItems[1]);

        }
    }
}
