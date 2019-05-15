using System;
using System.Collections.Generic;
using System.IO;

namespace Payslip
{
    class Program
    {
        private static void Main(string[] args)
        {
            var pathFromName = @"C:\Users\StephanieK\source\payslip-kata\Payslip\Employees.csv";

            var csvParser = new CsvParser();
            var employeeInformatics = csvParser.GetCsvContents(pathFromName);

            var payslipBuilder = new PayslipBuilder();

            List<PayslipStatement> employeePayslips = (payslipBuilder.BuildPayslip(employeeInformatics));

            var pathToPrintTo = @"C:\Users\StephanieK\source\payslip-kata\Payslip\Payslip-Statements.csv";

            PayslipWriter writer = new PayslipWriter();
            writer.WritePayslipCsv(employeePayslips, pathToPrintTo);
        }
    }
}
