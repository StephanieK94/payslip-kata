using System;
using System.Collections.Generic;

namespace Payslip
{
    public class CommaSeparator
    {
        public string GetFullNameFrom(string firstName, string lastName)
        {
            var employeeName = firstName + " " + lastName;

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

            string[] employeeDetails = GetEmployeeDetailsFrom(employeeFile);

            employeeInfo.FirstName = employeeDetails[0];
            employeeInfo.LastName = employeeDetails[1];
            employeeInfo.EmployeeSalary = employeeDetails[2];
            employeeInfo.EmployeePayRate = employeeDetails[3];
            employeeInfo.PayPeriod = employeeDetails[4];
            employeeInfo.FullName = GetFullNameFrom(employeeDetails[0], employeeDetails[1]);
            
            return employeeInfo;
        }
    }

    public class EmployeeInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PayPeriod { get; set; }
        public string EmployeeSalary { get; set; }
        public string EmployeePayRate { get; set; }
        public string FullName { get; set; }
    }
}
