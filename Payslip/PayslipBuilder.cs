using System.Collections.Generic;

namespace Payslip
{
    public class PayslipBuilder
    {
        public List<EmployeePayslip> BuildPayslip(List<EmployeeInformation> employeeList)
        {
            var employeePayslips = new List<EmployeePayslip>();

            if (employeeList == null) return employeePayslips;

            foreach (var employee in employeeList)
            {
                var calculator = new TaxIncomeCalculations();
                var employeeCalculations = calculator.GetCalculations(employee);

                var payslip = new EmployeePayslip
                {
                    FullName = GetFullNameFrom(employee.FirstName, employee.LastName),
                    PayPeriod = employee.PayPeriod,
                    GrossIncome = employeeCalculations.GrossIncome,
                    IncomeTax = employeeCalculations.IncomeTax,
                    NetIncome = employeeCalculations.NetIncome,
                    SuperAmount = employeeCalculations.SuperAmount
                };

                employeePayslips.Add(payslip);
            }

            return employeePayslips;
        }

        public string GetFullNameFrom(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}