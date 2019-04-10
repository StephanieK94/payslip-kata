using System;
using System.Collections.Generic;

namespace Payslip
{
    public class CommaSeparator
    {
        public string GetFirstNameFrom(string employeeFile)
        {
            var employeeDetails = GetEmployeeDetailsFrom(employeeFile);

            var firstName = employeeDetails[0];

            return firstName;
        }

        public string GetLastNameFrom(string employeeFile)
        {
            var employeeDetails = GetEmployeeDetailsFrom(employeeFile);

            var lastName = employeeDetails[1];

            return lastName;
        }

        public string GetFullNameFrom(string employeeFile)
        {
            var employeeDetails = GetEmployeeDetailsFrom(employeeFile);

            var employeeName = employeeDetails[0] + " " + employeeDetails[1];

            return employeeName;
        }

        private string[] GetEmployeeDetailsFrom(string employeeFile)
        {
            string[] employeeDetails = employeeFile.Split(",");

            return employeeDetails;
        }

        public EmployeeInformation GetEmployeeInformation(string employeeFile)
        {
            var employeeInfo = new EmployeeInformation();

            var firstName = GetFirstNameFrom(employeeFile);
            employeeInfo.FirstName = firstName;

            return employeeInfo;
        }
    }

    public class EmployeeInformation
    {
        public string FirstName { get; set; }
    }
}
