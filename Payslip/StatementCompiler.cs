using System;

namespace Payslip
{
    public class StatementCompiler
    {
        public string CompileStrings(string[] employee)
        {
            string[] employeeStrings = employee;

            string employeeStatement = String.Join(",", employeeStrings);

            return employeeStatement;
        }
    }
}