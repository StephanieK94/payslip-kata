using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    public class CsvParser
    {
        public List<string> GetCsvContents(string pathName)
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