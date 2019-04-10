using System;
using System.Collections.Generic;

namespace Payslip
{
    public class CommaSeparator
    {
        public string GetFirstNameFrom(string employeeFile)
        {
            var employeeDetails = employeeFile.Split(",");

            var firstName = employeeDetails[0];

            return firstName;
        }

        public string GetLastNameFrom(string employeeFile)
        {
            var employeeDetails = employeeFile.Split(",");

            var lastName = employeeDetails[1];

            return lastName;
        }

        public string GetFullNameFrom(string employeeFile)
        {
            var employeeDetails = employeeFile.Split(",");

            var employeeName = employeeDetails[0] + " " + employeeDetails[1];

            return employeeName;
        }

        public string[] GetEmployeeDetailsFrom(string employeeFile)
        {
            string[] employeeDetails = employeeFile.Split(",");


            return employeeDetails;
        }
    }
}
