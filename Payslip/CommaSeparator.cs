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

            employeeInfo.FirstName = GetFirstNameFrom(employeeFile);
            employeeInfo.LastName = GetLastNameFrom(employeeFile);
            employeeInfo.PayPeriod = GetPayPeriodFrom(employeeFile);
            
            return employeeInfo;
        }

        public string GetPayPeriodFrom(string employeeFile)
        {
            var employeeDetails = GetEmployeeDetailsFrom(employeeFile);

            var payPeriod = employeeDetails[4];

            return payPeriod;
        }
    }

    public class EmployeeInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PayPeriod { get; set; }
    }
}
