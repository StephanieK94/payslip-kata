using System.Collections.Generic;

namespace Payslip
{
    public class EmployeeDetails
    {
        public string GetFullNameFrom(string firstName, string lastName)
        {
            var employeeName = firstName + " " + lastName;

            return employeeName;
        }
    }
}
