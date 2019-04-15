using System;
using System.Collections;
using System.Collections.Generic;
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

            List<string> lines = GetCsvContents(pathName);

            Assert.Equal("David,Rudd,60050,9%,01 March – 31 March", lines[0]);
            Assert.Equal("Ryan,Chen,120000,10%,01 March – 31 March", lines[1]);

        }


        private List<string> GetCsvContents(string pathName)
        {
            List<string> employeeStrings = new List<string>();

            using (var reader = new StreamReader(pathName))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    employeeStrings.Add(line);
                }
            }

            return employeeStrings;
        }
    }
}
