using System;
using System.Collections;
using System.IO;
using Newtonsoft.Json.Linq;
using Xunit;

namespace payslip.tests
{
    public class CSVTests
    {
        [Fact]
        public void GetCsvFile()
        {
            string path = Directory.GetCurrentDirectory();

            string pathName = Path.GetDirectoryName(path);

            Assert.Equal("C:\\Users\\StephanieK\\source\\payslip-kata\\payslip.tests\\bin\\Debug", pathName);
        }

        [Fact]
        public void ReadCsvFile()
        {
            string path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";

            var lines = GetCsvContents(pathName);

            Assert.Equal("David,Rudd,60050,9%,01 March – 31 March\r\nRyan,Chen,120000,10%,01 March – 31 March", lines);
        }

        private string GetCsvContents(string pathName)
        {
            string employeeStrings = null;

            using (var reader = new StreamReader(pathName))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadToEnd();

                    employeeStrings = line;
                }
            }

            return employeeStrings;
        }
    }
}
