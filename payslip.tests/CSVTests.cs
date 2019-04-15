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
            string path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";
            var parser = new CsvParser2();

            List<string> lines = parser.GetCsvContents(pathName);

            Assert.Equal("David,Rudd,60050,9%,01 March – 31 March", lines[0]);
            Assert.Equal("Ryan,Chen,120000,10%,01 March – 31 March", lines[1]);

        }
    }
}
