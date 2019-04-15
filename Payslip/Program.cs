using System;
using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Directory.GetCurrentDirectory();

            var pathName = $"{path}\\Employee.csv";

            var csvParser = new CsvParser();

            var companyEmployeeInformation = csvParser.GetCsvContents(pathName);

            var payslipBuilder = new PayslipBuilder();

            var employeePayslips = new List<EmployeePayslip>();

            employeePayslips = (payslipBuilder.BuildPayslip(companyEmployeeInformation));

            Console.WriteLine(employeePayslips);
        }
    }
}
