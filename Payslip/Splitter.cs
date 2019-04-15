namespace Payslip
{
    public class Splitter
    {
        public EmployeeInformation SplitString(string employee)
        {
            var split = employee.Split(',');

            var employeeInformation = new EmployeeInformation
            {
                FirstName = split[0],
                LastName = split[1],
                Salary = decimal.Parse(split[2]),
                PayRate = decimal.Parse(split[3].Trim('%')),
                PayPeriod = split[4]
            };

            return employeeInformation;
        }
    }
}

// Merge this into the CsvParser so that it splits each line and assigns it into the employeeInformation, will return a List<EmployeeInformation>