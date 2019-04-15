namespace Payslip
{
    public class PayslipBuilder
    {
        public EmployeePayslip BuildPayslip(EmployeeInformation employee, CalculationInformation calculations)
        {
            var employeePayslips = new EmployeePayslip
            {
                FullName = GetFullNameFrom(employee.FirstName, employee.LastName),
                PayPeriod = employee.PayPeriod,
                GrossIncome = calculations.GrossIncome,
                IncomeTax = calculations.IncomeTax,
                NetIncome = calculations.NetIncome,
                SuperAmount = calculations.SuperAmount
            };

            return employeePayslips;
        }

        public string GetFullNameFrom(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}