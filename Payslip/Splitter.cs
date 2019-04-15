namespace Payslip
{
    public class Splitter
    {
        public EmployeeInformation SplitString(string employee)
        {
            var foo = employee.Split(',');

            var employeeInformation = new EmployeeInformation
            {
                FirstName = foo[0],
                LastName = foo[1],
                Salary = decimal.Parse(foo[2]),
                PayRate = decimal.Parse(foo[3].Trim('%')),
                PayPeriod = foo[4]
            };

            return employeeInformation;
        }
    }
}