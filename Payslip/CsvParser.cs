﻿using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    public class CsvParser
    {
        public List<EmployeeInformation> GetCsvContents(string pathName)
        {
            var employeeLineItems = new List<EmployeeInformation>();

            using (var reader = new StreamReader(@pathName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine()?.Split(',');

                    if (line == null) continue;
                    var employeeInformation = new EmployeeInformation
                    {
                        FirstName = line[0],
                        LastName = line[1],
                        Salary = decimal.Parse(line[2]),
                        PayRate = decimal.Parse(line[3].Trim('%')),
                        PayPeriod = line[4]
                    };

                    employeeLineItems.Add(employeeInformation);
                }
            }
            return employeeLineItems;
        }
    }
}