using System;

namespace Payslip
{
    public class PayslipCompiler
    {
        public string CompileStrings(EmployeeInformation employee)
        {
            EmployeeInformation employeeInfo = employee;

            var fullName = GetFullNameFrom(employeeInfo.FirstName, employeeInfo.LastName);

            string[] employeeStrings =
            {
                fullName, employeeInfo.PayPeriod, employeeInfo.GrossIncome, employeeInfo.IncomeTax,
                employeeInfo.NetIncome, employeeInfo.SuperAmount
            };

            string employeeStatement = String.Join(",", employeeStrings);

            return employeeStatement;
        }

        public string GetFullNameFrom(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}