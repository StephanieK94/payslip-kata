using System;

namespace Payslip
{
    public class PayslipCompiler
    {
        public string FullName { get; set; }

        

        public string CompileStrings(EmployeeInformation employee, CalculationInformation calculations)
        {
            FullName = GetFullNameFrom(employee.FirstName, employee.LastName);

            string[] employeeStrings =
            {
                FullName, employee.PayPeriod, calculations.GrossIncome, calculations.IncomeTax,
                calculations.NetIncome, calculations.SuperAmount
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