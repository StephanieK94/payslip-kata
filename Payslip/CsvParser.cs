using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    public class CsvParser
    {
        public List<string> GetCsvContents(string pathName)
        {
            var employeeLineItems = new List<string>();

            using (var reader = new StreamReader(pathName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();

                    employeeLineItems.Add(line);
                }
            }
            return employeeLineItems;
        }
    }
}