using System;

namespace Payslip
{
    public class StatementCompiler
    {
        public string CompileStrings(EmployeeInformation employee)
        {
            EmployeeInformation employeeInfo = employee;

            string[] employeeStrings =
            {
                employeeInfo.FullName, employeeInfo.PayPeriod, employeeInfo.GrossIncome, employeeInfo.IncomeTax,
                employeeInfo.NetIncome, employeeInfo.SuperAmount
            };

            string employeeStatement = String.Join(",", employeeStrings);

            return employeeStatement;
        }
    }
}