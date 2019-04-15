using System;

namespace Payslip
{
    public class TaxIncomeCalculations
    {
        public decimal GetRoundedCalculationAsInteger(decimal calculation)
        {
            return Convert.ToInt32(Math.Round(calculation, MidpointRounding.AwayFromZero));
        }

        public decimal GetGrossIncome(decimal salary)
        {
            return GetRoundedCalculationAsInteger(salary / 12);
        }

        public decimal GetIncomeTax(decimal salary)
        {
            var monthlyIncomeTax = 0M;

            if (salary <= 18200)
            {
                monthlyIncomeTax = 0;
            }

            if (salary >= 18201 && salary <= 37000)
            {
                monthlyIncomeTax = ((salary - 18200) * 0.19M) / 12;
            }

            if (salary >= 37001 && salary <= 80000)
            {
                monthlyIncomeTax = (((salary - 37000) * 0.325M) + 3572) / 12;
            }

            if (salary >= 80001 && salary <= 180000)
            {
                monthlyIncomeTax = (((salary - 80000) * 0.37M) + 17547) / 12;
            }

            if (salary >= 180001 && salary >= 180001)
            {
                monthlyIncomeTax = (((salary - 180000) * 0.45M) + 54547) / 12;
            }

            return GetRoundedCalculationAsInteger(monthlyIncomeTax);
        }

        public decimal GetNetIncome(decimal grossIncome, decimal incomeTax)
        {
            var netIncome = grossIncome - incomeTax;

            return GetRoundedCalculationAsInteger(netIncome);
        }

        public decimal GetSuperAmount(decimal grossIncome, decimal payRate)
        {
            var superAmount = grossIncome * payRate / 100;

            return GetRoundedCalculationAsInteger(superAmount);
        }

        public CalculationInformation GetCalculations(EmployeeInformation employeeInformation)
        {
            var calculatedEmployee = new CalculationInformation();

            calculatedEmployee.GrossIncome = GetGrossIncome(employeeInformation.Salary);
            calculatedEmployee.IncomeTax = GetIncomeTax(employeeInformation.Salary);
            calculatedEmployee.NetIncome = GetNetIncome(calculatedEmployee.GrossIncome, calculatedEmployee.IncomeTax);
            calculatedEmployee.SuperAmount =
                GetSuperAmount(calculatedEmployee.GrossIncome, employeeInformation.PayRate);

            return calculatedEmployee;
        }
    }

}