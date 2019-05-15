using System.Collections.Generic;

namespace Payslip
{
    public class PayslipBuilder
    {
        public List<PayslipStatement> BuildPayslip(List<Employee> employeeList)
        {
            var employeePayslipsList = new List<PayslipStatement>();

            if (employeeList == null) return employeePayslipsList;

            foreach (var employee in employeeList)
            {
                var taxCalculator = new TaxIncomeCalculations();
                CalculationInformation taxCalculationsForPayslip = taxCalculator.GetPayslipCalculations(employee);

                var payslip = new PayslipStatement
                {
                    FullName = GetFullNameFrom(employee.FirstName, employee.LastName),
                    PayPeriod = employee.PayPeriod,
                    GrossIncome = taxCalculationsForPayslip.GrossIncome,
                    IncomeTax = taxCalculationsForPayslip.IncomeTax,
                    NetIncome = taxCalculationsForPayslip.NetIncome,
                    SuperAmount = taxCalculationsForPayslip.SuperAmount
                };

                employeePayslipsList.Add(payslip);
            }

            return employeePayslipsList;
        }

        public string GetFullNameFrom(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}