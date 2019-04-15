using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    public class CsvParser
    {
        public List<EmployeeInformation> GetCsvContents(string pathName)
        {
            var employeeLineItems = new List<EmployeeInformation>();

            using (var reader = new StreamReader(pathName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    var splitter = new Splitter();

                    var splitLine = splitter.SplitString(line);

                    employeeLineItems.Add(splitLine);
                }
            }
            return employeeLineItems;
        }
    }
}