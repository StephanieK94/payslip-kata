using System;
using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    class Program
    {
        private static void Main(string[] args)
        {
            //var path = Directory.GetCurrentDirectory();

            //var pathName = $"{path}\\Employee.csv";

            var csvParser = new CsvParser();

            var employeeInformatics = csvParser.GetCsvContents("C:\\Users\\StephanieK\\source\\payslip-kata\\payslip.tests\\bin\\Debug\\netcoreapp2.1\\Employee.csv");

            var payslipBuilder = new PayslipBuilder();

            var employeePayslips = (payslipBuilder.BuildPayslip(employeeInformatics));

            Console.WriteLine(employeePayslips);
        }
    }
}
