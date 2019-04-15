namespace Payslip
{
    public class PayslipBuilder
    {
        public EmployeePayslip BuildPayslip(EmployeeInformation employee)
        {
            var calculator = new TaxIncomeCalculations();
            var employeeCalculations = calculator.GetCalculations(employee);

            var employeePayslips = new EmployeePayslip
            {
                FullName = GetFullNameFrom(employee.FirstName, employee.LastName),
                PayPeriod = employee.PayPeriod,
                GrossIncome = employeeCalculations.GrossIncome,
                IncomeTax = employeeCalculations.IncomeTax,
                NetIncome = employeeCalculations.NetIncome,
                SuperAmount = employeeCalculations.SuperAmount
            };

            return employeePayslips;
        }

        public string GetFullNameFrom(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}